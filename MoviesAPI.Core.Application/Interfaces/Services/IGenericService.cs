using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAPI.Core.Application.Interfaces.Services
{
    public interface IGenericService<EntityDto, Entity>
        where EntityDto : class
        where Entity : class
    {
        Task<List<EntityDto>> GetAllAsync();
        Task<EntityDto> GetByIdAsync(int id);
        Task<EntityDto> AddAsync(EntityDto dto);
        Task UpdateAsync(EntityDto dto, int id);
        Task DeleteAsync(int id);
    }
}
