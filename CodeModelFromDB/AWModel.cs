namespace CodeModelFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AWModel : DbContext
    {
        public AWModel()
            : base("name=AWModel")
        {
        }

        public virtual DbSet<WS_ATTENDEES> WS_ATTENDEES { get; set; }
        public virtual DbSet<WS_COMMITTEE_CATEGORIES> WS_COMMITTEE_CATEGORIES { get; set; }
        public virtual DbSet<WS_COMMITTEE_PERMISSIONS> WS_COMMITTEE_PERMISSIONS { get; set; }
        public virtual DbSet<WS_COMMITTEES> WS_COMMITTEES { get; set; }
        public virtual DbSet<WS_HR_ITEMS> WS_HR_ITEMS { get; set; }
        public virtual DbSet<WS_ITEM_CATEGORIES> WS_ITEM_CATEGORIES { get; set; }
        public virtual DbSet<WS_ITEM_FILES> WS_ITEM_FILES { get; set; }
        public virtual DbSet<WS_MEETING_ITEMS> WS_MEETING_ITEMS { get; set; }
        public virtual DbSet<WS_MEETING_LOG> WS_MEETING_LOG { get; set; }
        public virtual DbSet<WS_MEETINGS> WS_MEETINGS { get; set; }
        public virtual DbSet<WS_OTHER_ITEMS> WS_OTHER_ITEMS { get; set; }
        public virtual DbSet<WS_ROLES> WS_ROLES { get; set; }
        public virtual DbSet<WS_STATUSES> WS_STATUSES { get; set; }
        public virtual DbSet<WS_USERS> WS_USERS { get; set; }
        public virtual DbSet<DB_SETTINGS> DB_SETTINGS { get; set; }
        public virtual DbSet<DEPARTMENTS_VW> DEPARTMENTS_VW { get; set; }
        public virtual DbSet<DIVISON_VW> DIVISON_VW { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WS_ATTENDEES>()
                .Property(e => e.ATTENDEE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ATTENDEES>()
                .Property(e => e.ATTENDED)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ATTENDEES>()
                .Property(e => e.APPROVE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ATTENDEES>()
                .Property(e => e.MEETING_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ATTENDEES>()
                .Property(e => e.COMMITTEE_PERMISSION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ATTENDEES>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ATTENDEES>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_CATEGORIES>()
                .Property(e => e.COMMITTEE_CATEGORY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_CATEGORIES>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_CATEGORIES>()
                .Property(e => e.DISPLAY_ORDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WS_COMMITTEE_CATEGORIES>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_CATEGORIES>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_CATEGORIES>()
                .Property(e => e.COMMITTEE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_CATEGORIES>()
                .Property(e => e.ITEM_CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_CATEGORIES>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_CATEGORIES>()
                .HasMany(e => e.WS_MEETING_ITEMS)
                .WithOptional(e => e.WS_COMMITTEE_CATEGORIES)
                .HasForeignKey(e => e.CATEGORY_CODE);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .Property(e => e.PERMISSIONS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .Property(e => e.DISPLAY_ORDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .Property(e => e.ROLE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .Property(e => e.COMMITTEE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .Property(e => e.MODIFIED_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .HasMany(e => e.WS_ATTENDEES)
                .WithRequired(e => e.WS_COMMITTEE_PERMISSIONS)
                .HasForeignKey(e => e.COMMITTEE_PERMISSION_CODE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .HasMany(e => e.WS_MEETINGS)
                .WithOptional(e => e.WS_COMMITTEE_PERMISSIONS)
                .HasForeignKey(e => e.FINAL_APPROVER_CODE);

            modelBuilder.Entity<WS_COMMITTEE_PERMISSIONS>()
                .HasMany(e => e.WS_MEETINGS1)
                .WithOptional(e => e.WS_COMMITTEE_PERMISSIONS1)
                .HasForeignKey(e => e.REVIEWER_CODE);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.COMMITTEE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.ADMIN)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.LANGUAGE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.TITLE_ARABIC)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.DESCRIPTION_ARABIC)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.MEETING_NUMBER_START)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.FINAL_APPROVAL_REQUIRED)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .Property(e => e.REVIEW_REQUIRED)
                .IsUnicode(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .HasMany(e => e.WS_COMMITTEE_CATEGORIES)
                .WithRequired(e => e.WS_COMMITTEES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .HasMany(e => e.WS_COMMITTEE_PERMISSIONS)
                .WithRequired(e => e.WS_COMMITTEES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WS_COMMITTEES>()
                .HasMany(e => e.WS_MEETINGS)
                .WithRequired(e => e.WS_COMMITTEES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WS_HR_ITEMS>()
                .Property(e => e.HR_ITEM_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_HR_ITEMS>()
                .Property(e => e.DEPT_ORG_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_HR_ITEMS>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_HR_ITEMS>()
                .Property(e => e.MEETING_ITEM_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_HR_ITEMS>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_HR_ITEMS>()
                .Property(e => e.EMPLOYEE_BANNER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WS_HR_ITEMS>()
                .Property(e => e.EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WS_HR_ITEMS>()
                .Property(e => e.EMPLOYEE_JOB_TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_HR_ITEMS>()
                .Property(e => e.EMPLOYEE_GRADE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_HR_ITEMS>()
                .Property(e => e.DEPT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ITEM_CATEGORIES>()
                .Property(e => e.ITEM_CATEGORY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ITEM_CATEGORIES>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ITEM_CATEGORIES>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ITEM_CATEGORIES>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ITEM_CATEGORIES>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ITEM_CATEGORIES>()
                .Property(e => e.TITLE_ARABIC)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ITEM_CATEGORIES>()
                .Property(e => e.ABBREVIATION)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ITEM_CATEGORIES>()
                .HasMany(e => e.WS_COMMITTEE_CATEGORIES)
                .WithOptional(e => e.WS_ITEM_CATEGORIES)
                .HasForeignKey(e => e.ITEM_CATEGORY);

            modelBuilder.Entity<WS_ITEM_FILES>()
                .Property(e => e.ITEM_FILE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ITEM_FILES>()
                .Property(e => e.MEETING_ITEM_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ITEM_FILES>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ITEM_FILES>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.MEETING_ITEM_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.COMMITTEE_APPROVAL)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.COMMITTEE_RECOMMENDATION)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.REVIEWER_REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.FINAL_APPROVAL)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.CATEGORY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.MEETING_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.REQUEST)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .Property(e => e.EXECUTE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .HasMany(e => e.WS_HR_ITEMS)
                .WithOptional(e => e.WS_MEETING_ITEMS)
                .WillCascadeOnDelete();

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .HasMany(e => e.WS_ITEM_FILES)
                .WithOptional(e => e.WS_MEETING_ITEMS)
                .WillCascadeOnDelete();

            modelBuilder.Entity<WS_MEETING_ITEMS>()
                .HasMany(e => e.WS_OTHER_ITEMS)
                .WithOptional(e => e.WS_MEETING_ITEMS)
                .WillCascadeOnDelete();

            modelBuilder.Entity<WS_MEETING_LOG>()
                .Property(e => e.MEETING_LOG_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_LOG>()
                .Property(e => e.TEXT)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_LOG>()
                .Property(e => e.MEETING_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_LOG>()
                .Property(e => e.PERMISSION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETING_LOG>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.MEETING_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.MEETING_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.MEETING_YEAR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.LOCATION)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.COMMITTEE_APPROVAL)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.FINAL_APPROVAL)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.COMMITTEE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.START_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.END_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.FINAL_APPROVER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .Property(e => e.REVIEWER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .HasMany(e => e.WS_ATTENDEES)
                .WithRequired(e => e.WS_MEETINGS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WS_MEETINGS>()
                .HasMany(e => e.WS_MEETING_LOG)
                .WithOptional(e => e.WS_MEETINGS)
                .WillCascadeOnDelete();

            modelBuilder.Entity<WS_OTHER_ITEMS>()
                .Property(e => e.OTHER_ITEM_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_OTHER_ITEMS>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_OTHER_ITEMS>()
                .Property(e => e.REQUESTER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WS_OTHER_ITEMS>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_OTHER_ITEMS>()
                .Property(e => e.CREATED_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_OTHER_ITEMS>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_OTHER_ITEMS>()
                .Property(e => e.MODIFIED_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_OTHER_ITEMS>()
                .Property(e => e.MEETING_ITEM_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_OTHER_ITEMS>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ROLES>()
                .Property(e => e.ROLE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ROLES>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ROLES>()
                .Property(e => e.TITLE_ARABIC)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ROLES>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ROLES>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ROLES>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ROLES>()
                .Property(e => e.DESCRIPTION_ARABIC)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ROLES>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ROLES>()
                .Property(e => e.ABBREVIATION)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ROLES>()
                .Property(e => e.ATTEND_MEETING)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ROLES>()
                .Property(e => e.DISPLAY_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<WS_ROLES>()
                .HasMany(e => e.WS_COMMITTEE_PERMISSIONS)
                .WithRequired(e => e.WS_ROLES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WS_STATUSES>()
                .Property(e => e.STATUS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_STATUSES>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_STATUSES>()
                .Property(e => e.TITLE_ARABIC)
                .IsUnicode(false);

            modelBuilder.Entity<WS_STATUSES>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_STATUSES>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<WS_USERS>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WS_USERS>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WS_USERS>()
                .Property(e => e.NAME_ARABIC)
                .IsUnicode(false);

            modelBuilder.Entity<WS_USERS>()
                .Property(e => e.BANNER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WS_USERS>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<WS_USERS>()
                .Property(e => e.ORG_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WS_USERS>()
                .Property(e => e.ORG_TITLE_ENG)
                .IsUnicode(false);

            modelBuilder.Entity<WS_USERS>()
                .Property(e => e.ORG_TITLE_ARA)
                .IsUnicode(false);

            modelBuilder.Entity<WS_USERS>()
                .Property(e => e.POSN_NO)
                .IsUnicode(false);

            modelBuilder.Entity<WS_USERS>()
                .Property(e => e.POSN_TITLE_ENG)
                .IsUnicode(false);

            modelBuilder.Entity<WS_USERS>()
                .Property(e => e.POSN_TITLE_ARA)
                .IsUnicode(false);

            modelBuilder.Entity<WS_USERS>()
                .Property(e => e.GRADE)
                .IsUnicode(false);

            modelBuilder.Entity<DB_SETTINGS>()
                .Property(e => e.SETTING_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<DB_SETTINGS>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<DB_SETTINGS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<DB_SETTINGS>()
                .Property(e => e.CREATED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<DB_SETTINGS>()
                .Property(e => e.MODIFIED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENTS_VW>()
                .Property(e => e.ORG_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENTS_VW>()
                .Property(e => e.ORG_NAME_ENG)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENTS_VW>()
                .Property(e => e.ORG_NAME_ARA)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENTS_VW>()
                .Property(e => e.ORG_PARENT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<DIVISON_VW>()
                .Property(e => e.ORG_PARENT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<DIVISON_VW>()
                .Property(e => e.ORG_PARENT_NAME_ENG)
                .IsUnicode(false);

            modelBuilder.Entity<DIVISON_VW>()
                .Property(e => e.ORG_PARENT_NAME_ARA)
                .IsUnicode(false);
        }
    }
}
