﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NbaManagement.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<PlayerPosition> PlayerPosition { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<College> Colleges { get; set; }
        public virtual DbSet<Conference> Conferences { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Matchup> Matchups { get; set; }
        public virtual DbSet<MatchupStatu> MatchupStatus { get; set; }
        public virtual DbSet<MatchupType> MatchupTypes { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
    }
}
