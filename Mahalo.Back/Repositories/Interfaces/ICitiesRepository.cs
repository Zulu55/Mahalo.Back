﻿using Mahalo.Shared.DTOs;
using Mahalo.Shared.Entities;
using Mahalo.Shared.Response;

namespace Mahalo.Back.Repositories.Interfaces
{
    public interface ICitiesRepository
    {
        Task<ActionResponse<City>> GetAsync(int id);

        Task<ActionResponse<IEnumerable<City>>> GetAsync();

        Task<IEnumerable<City>> GetComboAsync();

        Task<ActionResponse<IEnumerable<City>>> GetAsync(PaginationDTO pagination);

        Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
    }
}