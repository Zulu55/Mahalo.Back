﻿using Mahalo.Back.Data;
using Mahalo.Back.Helpers;
using Mahalo.Back.Repositories.Interfaces;
using Mahalo.Shared.DTOs;
using Mahalo.Shared.Entities;
using Mahalo.Shared.Response;
using Microsoft.EntityFrameworkCore;

namespace Mahalo.Back.Repositories.Implementation
{
    public class TerapiesRepository : GenericRepository<Terapy>, ITerapiesRepository
    {
        private readonly DataContext _context;

        public TerapiesRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<Terapy>> GetAsync(int id)
        {
            var terapy = await _context.Terapy
                .Include(x => x.City)
                .FirstOrDefaultAsync(x => x.id == id);

            if (terapy == null)
            {
                return new ActionResponse<Terapy>
                {
                    MasSuccess = false,
                    Message = "ERR001"
                };
            }

            return new ActionResponse<Terapy>
            {
                MasSuccess = true,
                Result = terapy
            };
        }

        public override async Task<ActionResponse<IEnumerable<Terapy>>> GetAsync()
        {
            var terapies = await _context.Terapy
                .Include(x => x.City)
                .ToListAsync();
            return new ActionResponse<IEnumerable<Terapy>>
            {
                MasSuccess = true,
                Result = terapies
            };
        }

        public async Task<IEnumerable<Terapy>> GetComboAsync()
        {
            return await _context.Terapy
                .OrderBy(x => x.HourTerapy)
                .ToListAsync();
        }

        public override async Task<ActionResponse<IEnumerable<Terapy>>> GetAsync(PaginationDTO pagination)
        {
            var queryable = _context.Terapy
                .Include(x => x.id)
                .OrderBy(x => x.HourTerapy)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(pagination.Filter))
            {
                queryable = queryable.Where(x => x.Name.ToLower().Contains(pagination.Filter.ToLower()));
            }

            return new ActionResponse<IEnumerable<Terapy>>
            {
                WasSuccess = true,
                Result = await queryable
                    .OrderBy(x => x.Name)
                    .Paginate(pagination)
                    .ToListAsync()
            };
        }

        public async Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination)
        {
            var queryable = _context.Terapy.AsQueryable();

            if (!string.IsNullOrWhiteSpace(pagination.Filter))
            {
                queryable = queryable.Where(x => x.Name.Contains(pagination.Filter, StringComparison.CurrentCultureIgnoreCase));
            }

            double count = await queryable.CountAsync();
            return new ActionResponse<int>
            {
                WasSuccess = true,
                Result = (int)count
            };
        }
    }
}