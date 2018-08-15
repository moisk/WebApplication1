using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers;

namespace WebApplication1.Core
{
    public interface IUnitofWork 
    {
        ContactController contact { get; }
        void Complete();
    }
}
