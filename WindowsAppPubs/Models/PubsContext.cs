using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsAppPubs.Models
{
    public partial class PubsContext : DbContext
    {
        public PubsContext()
            : base("name=PubsContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<PubInfo> PubInfos { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Author> Stores { get; set; }
        public virtual DbSet<Titleauthor> Sitleauthor { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Roysched> Roysched { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(e => e.au_id)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.au_lname)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.au_fname)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.titleauthor)
                .WithRequired(e => e.authors)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.emp_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.minit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.job_desc)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.employee)
                .WithRequired(e => e.jobs)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PubInfo>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PubInfo>()
                .Property(e => e.pr_info)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.pub_name)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .HasMany(e => e.employee)
                .WithRequired(e => e.Publishers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Publisher>()
                .HasOptional(e => e.pub_info)
                .WithRequired(e => e.publishers);

            modelBuilder.Entity<Sale>()
                .Property(e => e.stor_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.ord_num)
                .IsUnicode(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.payterms)
                .IsUnicode(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.title_id)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.stor_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.stor_name)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.stor_address)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.sales)
                .WithRequired(e => e.stores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Titleauthor>()
                .Property(e => e.au_id)
                .IsUnicode(false);

            modelBuilder.Entity<Titleauthor>()
                .Property(e => e.title_id)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.title_id)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Title>()
                .Property(e => e.advance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Title>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.sales)
                .WithRequired(e => e.titles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.titleauthor)
                .WithRequired(e => e.titles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Title>()
                .HasOptional(e => e.roysched)
                .WithRequired(e => e.titles);

            modelBuilder.Entity<Discount>()
                .Property(e => e.discounttype)
                .IsUnicode(false);

            modelBuilder.Entity<Discount>()
                .Property(e => e.stor_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Discount>()
                .Property(e => e.discount)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Roysched>()
                .Property(e => e.title_id)
                .IsUnicode(false);
        }
    }
}
