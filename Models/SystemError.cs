using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scorcher.Enums;

namespace Scorcher.Models
{
    public class SystemError<T>
    {
        public int Id { get; set; }
        public string? ErrorMessage { get; set; }
        public T? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public ErrorType ErrorType { get; set; }

    }
}
