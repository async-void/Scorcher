using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scorcher.Models;
using Scorcher.Services;

namespace Scorcher.Interfaces
{
    public interface IConfig
    {
        Result<string, SystemError<DataService>> GetToken();
    }
}
