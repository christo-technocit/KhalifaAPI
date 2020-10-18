using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KU.Repositories.Models;



namespace KU.Repositories
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public string CurrentUserId { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
          
        
        }

        //public DbSet<SavedForm> SavedForms { get; set; }
        public DbSet<SavedForm> SavedForm { get; set; }
        

        //public DbSet<Template> Templates { get; set; }
        public DbSet<Template> Template { get; set; }
        public DbSet<Section> Sections { get; set; }

        //public DbSet<FormAttribute> FormAttributes { get; set; }
        public DbSet<FormAttribute> FormAttribute { get; set; }

        //public DbSet<FormAttributeValue> FormAttributeValues { get; set; }
        public DbSet<FormAttributeValue> FormAttributeValue { get; set; }
    
        public DbSet<Questionnaire1> Questionnaire1 { get; set; }
        public DbSet<Questionnaire2> Questionnaire2 { get; set; }
        //    public DbSet<Questionnaire2section> Questionnaire2section { get; set; }
        //     public DbSet<Questionnaire2section.Section1> Questionnaire2section1 { get; set; }
        public DbSet<Questionnaire3> Questionnaire3 { get; set; }
        public DbSet<Questionnaire4> Questionnaire4 { get; set; }
        public DbSet<Questionnaire5> Questionnaire5 { get; set; }
        public DbSet<Questionnaire6> Questionnaire6 { get; set; }
        public DbSet<Questionnaire7> Questionnaire7 { get; set; }
        public DbSet<Questionnaire8> Questionnaire8 { get; set; }
        public DbSet<Questionnaire9> Questionnaire9 { get; set; }
        public DbSet<Questionnaire9_9> Questionnaire9_9 { get; set; }
        public DbSet<Questionnaire10> Questionnaire10 { get; set; }

        public DbSet<TotalRecords> Totalrecords { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        //  public DbSet<AspNetUsers> AspNetUser { get; set; }
        public DbSet<ApplicationUsers> ApplicationUsers { get; set; }

        // For Documents 
        public DbSet<FormAttributeValue_files> formAttributeValue_Files { get; set; }


        // for reports
        public DbSet<Questionnaire> Questionnaire { get; set; }

        public DbSet<Q1ViewModel> Q1ViewModel { get; set; }
        public DbSet<Q2ViewModel> Q2ViewModel { get; set; }
        public DbSet<Q3ViewModel> Q3ViewModel { get; set; }
        public DbSet<Q4ViewModel> Q4ViewModel { get; set; }
        public DbSet<Q5ViewModel> Q5ViewModel { get; set; }
        public DbSet<Q6ViewModel> Q6ViewModel { get; set; }
        public DbSet<Q7ViewModel> Q7ViewModel { get; set; }
        public DbSet<Q8ViewModel> Q8ViewModel { get; set; }
        public DbSet<Q9ViewModel> Q9ViewModel { get; set; }
        public DbSet<Q9_9ViewModel> Q9_9ViewModel { get; set; }
        public DbSet<Q10ViewModel> Q10ViewModel { get; set; }

        // public DbSet<SP_GETDATA> SP_GETDATA { get;  }

        public DbSet<CountryMaster> CountryMaster { get; set; }


       // public DbSet<Common> Common { get; set; }



    }
}

