using FinalChallengeSubmission;
using System;
using System.Data.Entity;
using System.Linq;

namespace Model1
{
    
        public class SchoolContext : DbContext
        {
            public SchoolContext() : base()
            {

            }

            public DbSet<Student> Students { get; set; }
            public DbSet<Grade> Grades { get; set; }
        }
    
}