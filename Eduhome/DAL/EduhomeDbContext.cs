using Eduhome.Models;
using Microsoft.EntityFrameworkCore;

namespace Eduhome.DAL
{
    public class EduhomeDbContext:DbContext
    {
        public EduhomeDbContext(DbContextOptions<EduhomeDbContext> options):base(options)
        {
            
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CategoryC> CategoryCs { get; set; }
        public DbSet<CategoryE> CategoryEs { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<CourseTag> CourseTags { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<TeacherSkill> TeacherSkills { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Check> Checks { get; set; }


    }
}
