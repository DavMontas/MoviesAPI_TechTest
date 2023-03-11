using AutoMapper;
using MoviesAPI.Core.Application.Interfaces.Repositories;
using MoviesAPI.Core.Application.Interfaces.Services;

namespace MoviesAPI.Core.Application.Services
{
    public class GenericService<EntityDto, Entity> : IGenericService<EntityDto, Entity>
        where EntityDto : class
        where Entity : class
    {
        private readonly IGenericRepository<Entity> _repo;
        private readonly IMapper _mapper;
        public GenericService(IGenericRepository<Entity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<EntityDto>> GetAllAsync()
        {
            var entityList = await _repo.GetAllAsync();
            return  _mapper.Map<List<EntityDto>>(entityList);
        }

        public async Task<EntityDto> GetByIdAsync(int id)
        {
            Entity entity = await _repo.GetByIdAsync(id);
            return _mapper.Map<EntityDto>(entity);
        }

        public async Task<EntityDto> AddAsync(EntityDto dto)
        {
            Entity entity = _mapper.Map<Entity>(dto);
            entity = await _repo.AddAsync(entity);
            return _mapper.Map<EntityDto>(entity);
        }

        public virtual async Task UpdateAsync(EntityDto dto, int id)
        {
            Entity entity = _mapper.Map<Entity>(dto);
            await _repo.UpdateAsync(entity, id);
        }

        public virtual async Task DeleteAsync(int id)
        {
            Entity entity = await _repo.GetByIdAsync(id);
            await _repo.DeleteAsync(entity);
        }






    }
}
