﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPeriodicTable.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PeriodicTableQuizEntities : DbContext
    {
        public PeriodicTableQuizEntities()
            : base("name=PeriodicTableQuizEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnswerChoice> AnswerChoices { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<UserName> UserNames { get; set; }
    }
}
