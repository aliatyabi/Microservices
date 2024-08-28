using IDP.Domain.DTOs;
using IDP.Domain.IRepositories.Commands;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Infrastructure.Repositories.Commands
{
    public class OtpCommandRepository : IOtpCommandRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IConfiguration _configuration;

        public OtpCommandRepository(IDistributedCache distributedCache, IConfiguration configuration)
        {
            _distributedCache = distributedCache;
            _configuration = configuration;
        }

        public async Task<bool> Delete(OtpDto entity)
        {
             await _distributedCache.RemoveAsync(entity.UserId.ToString());

            return true;
        }

        public async Task<bool> Insert(OtpDto entity)
        {
            var time = Convert.ToInt32(_configuration.GetSection("Otp:OtpTime").Value);

            await _distributedCache.SetStringAsync(
                entity.UserId.ToString(),
                JsonConvert.SerializeObject(entity),
                new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(time)).SetAbsoluteExpiration(TimeSpan.FromMinutes(time))
                );

            return true;
        }

        public Task<bool> Update(OtpDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
