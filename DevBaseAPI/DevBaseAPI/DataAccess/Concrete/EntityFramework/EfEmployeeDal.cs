namespace DataAccess.Concrete.EntityFramework
{
    using Core.DataAccess.EntityFramework;
    using Entities.Concrete;
    using DataAccess.Abstract;
    using DataAccess.Concrete.EntityFramework.Contexts;

    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, EfContext>, IEmployeeDal
    {
    }
}
