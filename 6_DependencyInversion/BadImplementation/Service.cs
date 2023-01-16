using System;
using System.Collections.Generic;
using System.Text;

namespace _6_DependencyInversion.BadImplementation
{
    public class SQLRepository
    {
        public void save()
        { 
        }
    }
    public class NoSQLRepository
    {
        public void save()
        {
        }
    }
    public class Service
    {
        private SQLRepository repository = new SQLRepository();
        public void save() 
        {
            repository.save();
        }
    }
}
