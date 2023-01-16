using System;
using System.Collections.Generic;
using System.Text;

namespace _6_DependencyInversion.GodImplementation
{
    public interface Repository {
        void save();
    }
    public class SQLRepository : Repository
    {
        public void save()
        {
            //...
        }
    }
    public class NoSQLRepository : Repository
    {
        public void save()
        {
            //...
        }
    }
    public class Service
    {
        private Repository repository;

        public Service(Repository repository)
        {
            this.repository = repository;
        }

        public void save()
        {
            repository.save();
        }
    }
}
