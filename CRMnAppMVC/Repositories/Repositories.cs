using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CRMnAppMVC.Models;

namespace CRMnAppMVC.Repositories
{
//
    public  interface IRepository<Ttype> where Ttype:class
    {
        IEnumerable<Ttype> GetAll();
        IEnumerable<Ttype> GetAllWhere(Expression<Func<Ttype,bool>> expFunc);
        Ttype GetOne(int id);
    }
//
    public abstract class Repository<Ttype> : IRepository<Ttype> where Ttype : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public IEnumerable<Ttype> GetAll()
        {
            return Context.Set<Ttype>().ToList();
        }
        public IEnumerable<Ttype> GetAllWhere(Expression<Func<Ttype, bool>> expFunc)
        {
            return Context.Set<Ttype>().Where(expFunc).ToList();
        }
        
        public Ttype GetOne(int id)
        {
            return Context.Set<Ttype>().Find(id);
        }
    }
    //
    public class Repo_Activitati : Repository<Activitati_Curente>
    {
        public Repo_Activitati(CRM_Prospectare_Context context)
            : base(context)
        {
        }
    }

    public class Repo_Prospectare : Repository<Activitati_Curente>
        {
            public Repo_Prospectare(CRM_Prospectare_Context context)
                : base(context)
            {
            }


        }





}
