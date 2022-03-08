﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PETAS.Models.Domain.SecureAccess;

//using PANTrainerAPI.Models;

namespace PANTrainerAPI.Data
{
    public partial class SecureaccessContext : DbContext
    {
        public SecureaccessContext()
        {
        }

        public SecureaccessContext(DbContextOptions<SecureaccessContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArLiveSession> ArLiveSessions { get; set; }
        public virtual DbSet<ArLog> ArLogs { get; set; }
        public virtual DbSet<ArObject> ArObjects { get; set; }
        public virtual DbSet<ArObjectType> ArObjectTypes { get; set; }
        public virtual DbSet<ArPropertyValue> ArPropertyValues { get; set; }
        public virtual DbSet<ArReference> ArReferences { get; set; }
        public virtual DbSet<ArRelationship> ArRelationships { get; set; }
        public virtual DbSet<ArRelationshipAll> ArRelationshipAlls { get; set; }
        public virtual DbSet<ArRelationshipType> ArRelationshipTypes { get; set; }
        public virtual DbSet<ArUser> ArUsers { get; set; }
        public virtual DbSet<ArUserLog> ArUserLogs { get; set; }
        public virtual DbSet<ViewArAllApplication> ViewArAllApplications { get; set; }
        public virtual DbSet<ViewArAllApplicationPart> ViewArAllApplicationParts { get; set; }
        public virtual DbSet<ViewArAllApplicationProtectedArea> ViewArAllApplicationProtectedAreas { get; set; }
        public virtual DbSet<ViewArAllOrgUnit> ViewArAllOrgUnits { get; set; }
        public virtual DbSet<ViewArAllOwner> ViewArAllOwners { get; set; }
        public virtual DbSet<ViewArAllRole> ViewArAllRoles { get; set; }
        public virtual DbSet<ViewArAllUser> ViewArAllUsers { get; set; }
        public virtual DbSet<ViewArAllUserGroup> ViewArAllUserGroups { get; set; }
        public virtual DbSet<ViewArApplicationList> ViewArApplicationLists { get; set; }
        public virtual DbSet<ViewArLiveSession> ViewArLiveSessions { get; set; }
        public virtual DbSet<ViewArLog> ViewArLogs { get; set; }
        public virtual DbSet<ViewArLogJoined> ViewArLogJoineds { get; set; }
        public virtual DbSet<ViewArObject> ViewArObjects { get; set; }
        public virtual DbSet<ViewArObjectJoined> ViewArObjectJoineds { get; set; }
        public virtual DbSet<ViewArObjectProperty> ViewArObjectProperties { get; set; }
        public virtual DbSet<ViewArObjectType> ViewArObjectTypes { get; set; }
        public virtual DbSet<ViewArObjectUserJoined> ViewArObjectUserJoineds { get; set; }
        public virtual DbSet<ViewArObjectValid> ViewArObjectValids { get; set; }
        public virtual DbSet<ViewArOrgUnitJoined> ViewArOrgUnitJoineds { get; set; }
        public virtual DbSet<ViewArPermissionMatrix> ViewArPermissionMatrices { get; set; }
        public virtual DbSet<ViewArProperty> ViewArProperties { get; set; }
        public virtual DbSet<ViewArPropertyJoined> ViewArPropertyJoineds { get; set; }
        public virtual DbSet<ViewArPropertyType> ViewArPropertyTypes { get; set; }
        public virtual DbSet<ViewArPropertyValue> ViewArPropertyValues { get; set; }
        public virtual DbSet<ViewArPropertyValueJoined> ViewArPropertyValueJoineds { get; set; }
        public virtual DbSet<ViewArPropertyValueJoinedMatrix> ViewArPropertyValueJoinedMatrices { get; set; }
        public virtual DbSet<ViewArRelationship> ViewArRelationships { get; set; }
        public virtual DbSet<ViewArRelationshipAll> ViewArRelationshipAlls { get; set; }
        public virtual DbSet<ViewArRelationshipAllChild> ViewArRelationshipAllChildren { get; set; }
        public virtual DbSet<ViewArRelationshipAllChildValid> ViewArRelationshipAllChildValids { get; set; }
        public virtual DbSet<ViewArRelationshipAllParent> ViewArRelationshipAllParents { get; set; }
        public virtual DbSet<ViewArRelationshipAllParentValid> ViewArRelationshipAllParentValids { get; set; }
        public virtual DbSet<ViewArRelationshipAllValid> ViewArRelationshipAllValids { get; set; }
        public virtual DbSet<ViewArRelationshipChildJoined> ViewArRelationshipChildJoineds { get; set; }
        public virtual DbSet<ViewArRelationshipChildValid> ViewArRelationshipChildValids { get; set; }
        public virtual DbSet<ViewArRelationshipJoined> ViewArRelationshipJoineds { get; set; }
        public virtual DbSet<ViewArRelationshipParentJoined> ViewArRelationshipParentJoineds { get; set; }
        public virtual DbSet<ViewArRelationshipParentValid> ViewArRelationshipParentValids { get; set; }
        public virtual DbSet<ViewArRelationshipType> ViewArRelationshipTypes { get; set; }
        public virtual DbSet<ViewArRelationshipValid> ViewArRelationshipValids { get; set; }
        public virtual DbSet<ViewArRoleList> ViewArRoleLists { get; set; }
        public virtual DbSet<ViewArRoleMatrix> ViewArRoleMatrices { get; set; }
        public virtual DbSet<ViewArUser> ViewArUsers { get; set; }
        public virtual DbSet<ViewArUserGroupList> ViewArUserGroupLists { get; set; }
        public virtual DbSet<ViewArUserJoined> ViewArUserJoineds { get; set; }
        public virtual DbSet<ViewArUserList> ViewArUserLists { get; set; }
        public virtual DbSet<ViewArUserUnverified> ViewArUserUnverifieds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArLiveSession>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ArLog>(entity =>
            {
                entity.HasOne(d => d.ByObject)
                    .WithMany(p => p.ArLogByObjects)
                    .HasForeignKey(d => d.ByObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Log_AR_Object");

                entity.HasOne(d => d.ToObject)
                    .WithMany(p => p.ArLogToObjects)
                    .HasForeignKey(d => d.ToObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Log_AR_Object1");
            });

            modelBuilder.Entity<ArObject>(entity =>
            {
                entity.HasOne(d => d.ObjectType)
                    .WithMany(p => p.ArObjects)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Object_AR_ObjectType");
            });

            modelBuilder.Entity<ArPropertyValue>(entity =>
            {
                entity.HasKey(e => new { e.ObjectId, e.PropertyId });

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.ArPropertyValueObjects)
                    .HasForeignKey(d => d.ObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_PropertyValue_AR_Object");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.ArPropertyValueProperties)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_PropertyValue_AR_Object1");
            });

            modelBuilder.Entity<ArReference>(entity =>
            {
                entity.HasOne(d => d.ReferenceApplication)
                    .WithMany(p => p.ArReferences)
                    .HasForeignKey(d => d.ReferenceApplicationId)
                    .HasConstraintName("FK_AR_Reference_AR_Object");

                entity.HasOne(d => d.ReferenceObjectType)
                    .WithMany(p => p.ArReferences)
                    .HasForeignKey(d => d.ReferenceObjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Reference_AR_ObjectType");
            });

            modelBuilder.Entity<ArRelationship>(entity =>
            {
                entity.HasOne(d => d.ChildObject)
                    .WithMany(p => p.ArRelationshipChildObjects)
                    .HasForeignKey(d => d.ChildObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Relationship_AR_Object1");

                entity.HasOne(d => d.ParentObject)
                    .WithMany(p => p.ArRelationshipParentObjects)
                    .HasForeignKey(d => d.ParentObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Relationship_AR_Object");

                entity.HasOne(d => d.RelationshipType)
                    .WithMany(p => p.ArRelationships)
                    .HasForeignKey(d => d.RelationshipTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Relationship_AR_RelationshipType");
            });

            modelBuilder.Entity<ArRelationshipAll>(entity =>
            {
                entity.HasOne(d => d.ChildObject)
                    .WithMany()
                    .HasForeignKey(d => d.ChildObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_RelationshipAll_AR_Object1");

                entity.HasOne(d => d.ParentObject)
                    .WithMany()
                    .HasForeignKey(d => d.ParentObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_RelationshipAll_AR_Object");
            });

            modelBuilder.Entity<ArUser>(entity =>
            {
                entity.Property(e => e.ObjectId).ValueGeneratedNever();

                entity.HasOne(d => d.Object)
                    .WithOne(p => p.ArUser)
                    .HasForeignKey<ArUser>(d => d.ObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_User_AR_Object");
            });

            modelBuilder.Entity<ViewArAllApplication>(entity =>
            {
                entity.ToView("View_AR_AllApplications");
            });

            modelBuilder.Entity<ViewArAllApplicationPart>(entity =>
            {
                entity.ToView("View_AR_AllApplicationParts");
            });

            modelBuilder.Entity<ViewArAllApplicationProtectedArea>(entity =>
            {
                entity.ToView("View_AR_AllApplicationProtectedAreas");
            });

            modelBuilder.Entity<ViewArAllOrgUnit>(entity =>
            {
                entity.ToView("View_AR_AllOrgUnits");
            });

            modelBuilder.Entity<ViewArAllOwner>(entity =>
            {
                entity.ToView("View_AR_AllOwners");
            });

            modelBuilder.Entity<ViewArAllRole>(entity =>
            {
                entity.ToView("View_AR_AllRoles");
            });

            modelBuilder.Entity<ViewArAllUser>(entity =>
            {
                entity.ToView("View_AR_AllUsers");
            });

            modelBuilder.Entity<ViewArAllUserGroup>(entity =>
            {
                entity.ToView("View_AR_AllUserGroups");
            });

            modelBuilder.Entity<ViewArApplicationList>(entity =>
            {
                entity.ToView("View_AR_Application_List");

                entity.Property(e => e.ObjectId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewArLiveSession>(entity =>
            {
                entity.ToView("View_AR_LiveSession");
            });

            modelBuilder.Entity<ViewArLog>(entity =>
            {
                entity.ToView("View_AR_Log");

                entity.Property(e => e.LogId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewArLogJoined>(entity =>
            {
                entity.ToView("View_AR_Log_Joined");
            });

            modelBuilder.Entity<ViewArObject>(entity =>
            {
                entity.ToView("View_AR_Object");

                entity.Property(e => e.ObjectId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewArObjectJoined>(entity =>
            {
                entity.ToView("View_AR_Object_Joined");
            });

            modelBuilder.Entity<ViewArObjectProperty>(entity =>
            {
                entity.ToView("View_AR_Object_Properties");
            });

            modelBuilder.Entity<ViewArObjectType>(entity =>
            {
                entity.ToView("View_AR_ObjectType");

                entity.Property(e => e.ObjectTypeId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewArObjectUserJoined>(entity =>
            {
                entity.ToView("View_AR_ObjectUser_Joined");
            });

            modelBuilder.Entity<ViewArObjectValid>(entity =>
            {
                entity.ToView("View_AR_Object_Valid");

                entity.Property(e => e.ObjectId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewArOrgUnitJoined>(entity =>
            {
                entity.ToView("View_AR_OrgUnit_Joined");
            });

            modelBuilder.Entity<ViewArPermissionMatrix>(entity =>
            {
                entity.ToView("View_AR_PermissionMatrix");
            });

            modelBuilder.Entity<ViewArProperty>(entity =>
            {
                entity.ToView("View_AR_Property");
            });

            modelBuilder.Entity<ViewArPropertyJoined>(entity =>
            {
                entity.ToView("View_AR_Property_Joined");
            });

            modelBuilder.Entity<ViewArPropertyType>(entity =>
            {
                entity.ToView("View_AR_PropertyType");

                entity.Property(e => e.ObjectTypeId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewArPropertyValue>(entity =>
            {
                entity.ToView("View_AR_PropertyValue");
            });

            modelBuilder.Entity<ViewArPropertyValueJoined>(entity =>
            {
                entity.ToView("View_AR_PropertyValue_Joined");
            });

            modelBuilder.Entity<ViewArPropertyValueJoinedMatrix>(entity =>
            {
                entity.ToView("View_AR_PropertyValue_Joined_Matrix");
            });

            modelBuilder.Entity<ViewArRelationship>(entity =>
            {
                entity.ToView("View_AR_Relationship");

                entity.Property(e => e.RelationshipId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewArRelationshipAll>(entity =>
            {
                entity.ToView("View_AR_RelationshipAll");
            });

            modelBuilder.Entity<ViewArRelationshipAllChild>(entity =>
            {
                entity.ToView("View_AR_RelationshipAll_Child");
            });

            modelBuilder.Entity<ViewArRelationshipAllChildValid>(entity =>
            {
                entity.ToView("View_AR_RelationshipAll_Child_Valid");
            });

            modelBuilder.Entity<ViewArRelationshipAllParent>(entity =>
            {
                entity.ToView("View_AR_RelationshipAll_Parent");
            });

            modelBuilder.Entity<ViewArRelationshipAllParentValid>(entity =>
            {
                entity.ToView("View_AR_RelationshipAll_Parent_Valid");
            });

            modelBuilder.Entity<ViewArRelationshipAllValid>(entity =>
            {
                entity.ToView("View_AR_RelationshipAll_Valid");
            });

            modelBuilder.Entity<ViewArRelationshipChildJoined>(entity =>
            {
                entity.ToView("View_AR_Relationship_Child_Joined");
            });

            modelBuilder.Entity<ViewArRelationshipChildValid>(entity =>
            {
                entity.ToView("View_AR_Relationship_Child_Valid");
            });

            modelBuilder.Entity<ViewArRelationshipJoined>(entity =>
            {
                entity.ToView("View_AR_Relationship_Joined");
            });

            modelBuilder.Entity<ViewArRelationshipParentJoined>(entity =>
            {
                entity.ToView("View_AR_Relationship_Parent_Joined");
            });

            modelBuilder.Entity<ViewArRelationshipParentValid>(entity =>
            {
                entity.ToView("View_AR_Relationship_Parent_Valid");
            });

            modelBuilder.Entity<ViewArRelationshipType>(entity =>
            {
                entity.ToView("View_AR_RelationshipType");

                entity.Property(e => e.RelationshipTypeId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewArRelationshipValid>(entity =>
            {
                entity.ToView("View_AR_Relationship_Valid");
            });

            modelBuilder.Entity<ViewArRoleList>(entity =>
            {
                entity.ToView("View_AR_Role_List");
            });

            modelBuilder.Entity<ViewArRoleMatrix>(entity =>
            {
                entity.ToView("View_AR_RoleMatrix");
            });

            modelBuilder.Entity<ViewArUser>(entity =>
            {
                entity.ToView("View_AR_User");
            });

            modelBuilder.Entity<ViewArUserGroupList>(entity =>
            {
                entity.ToView("View_AR_UserGroup_List");

                entity.Property(e => e.ObjectId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewArUserJoined>(entity =>
            {
                entity.ToView("View_AR_User_Joined");
            });

            modelBuilder.Entity<ViewArUserList>(entity =>
            {
                entity.ToView("View_AR_User_List");
            });

            modelBuilder.Entity<ViewArUserUnverified>(entity =>
            {
                entity.ToView("View_AR_User_Unverified");
            });

            //OnModelCreatingGeneratedFunctions(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        #region test

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=10.150.0.241;Initial Catalog=SecureAccess;User ID=sa;Password=$Passw0rd");
        }

        #endregion

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}