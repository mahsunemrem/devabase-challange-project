
using Entities.Concrete;
using System;
using System.Linq.Expressions;

namespace Business.Statics
{
    public class IncludeStatic
    {
        public static Expression<Func<Employee, object>>[] IncludeEmployee = { };

    }
}

