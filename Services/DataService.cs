using Scorcher.Interfaces;
using Scorcher.Models;

namespace Scorcher.Services
{
    public class DataService : IConfig
    {
        public Result<string, SystemError<DataService>> GetToken()
        {
            throw new NotImplementedException();
        }
    }
}
