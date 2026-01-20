using Microsoft.EntityFrameworkCore;
using OrderDispatch.WebApi.Datebase;
using OrderDispatch.WebApi.Models.DTOs;

namespace OrderDispatch.WebApi.Repositories
{
    public class RiderRepository : IBaseRepository<RiderDto>
    {
        private DispatchContext context;

        public RiderRepository(DispatchContext context)
        {
            this.context = context;
        }


        public async Task<bool> CreateAsync(RiderDto entity) => true;

        public async Task<bool> DeleteAsync(int id) => true;

        public async Task<IEnumerable<RiderDto>> GetAllAsync() => new List<RiderDto>();

        public async Task<RiderDto> GetAsync(int id) => null;

        public async Task<bool> UpdateAsync(RiderDto entity) => true;
    }
}
