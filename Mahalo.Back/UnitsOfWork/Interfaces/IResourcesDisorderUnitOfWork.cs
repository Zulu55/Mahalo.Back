﻿using Mahalo.Shared.DTOs;
using Mahalo.Shared.Entities;
using Mahalo.Shared.Response;

namespace Mahalo.Back.UnitsOfWork.Interfaces
{
    public interface IResourcesDisorderUnitOfWork
    {
        Task<ActionResponse<ResourceDisorder>> GetAsync(int id);

        Task<ActionResponse<IEnumerable<ResourceDisorder>>> GetAsync();

        Task<IEnumerable<ResourceDisorder>> GetComboAsync();

        Task<ActionResponse<IEnumerable<ResourceDisorder>>> GetAsync(PaginationDTO pagination);

        Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
    }
}