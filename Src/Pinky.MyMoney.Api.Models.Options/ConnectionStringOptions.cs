using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinky.MyMoney.Api.Models.Options
{
    /// <summary>
    /// Connection string from the app settings.
    /// </summary>
    public class ConnectionStringOptions
    {
        public const string SectionName = "ConnectionStrings";
        public string? MyMoney {  get; set; }
    }
}
