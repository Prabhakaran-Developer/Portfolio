namespace MyPortfolio.Models
{

    public class PortfolioViewModel
    {
        public AboutMe? AboutMe { get; set; }
        public SkillsSection? Skills { get; set; }
        public ExperienceSection? Experience { get; set; }
        public ProjectsSection? Projects { get; set; }
        public EducationSection? Education { get; set; }
        public CertificationsSection? Certifications { get; set; }
    }

    public class AboutMe
    {
        public string? Title { get; set; }
        public string? Name { get; set; }
        public string? JobTitle { get; set; }
        public string? Description { get; set; }
        public string? Email { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? ProfileImagePath { get; set; }
    }

    public class SkillsSection
    {
        public List<SkillCategory>? SkillCategories { get; set; }
    }

    public class SkillCategory
    {
        public string? Name { get; set; }
        public string? IconClass { get; set; }
        public List<string>? Skills { get; set; }
    }

    public class ExperienceSection
    {
        public List<Experience>? Experiences { get; set; }
    }

    public class Experience
    {
        public string? DateRange { get; set; }
        public string? Company { get; set; }
        public string? Position { get; set; }
        public List<string>? Responsibilities { get; set; }
    }

    public class ProjectsSection
    {
        public List<Project>? Projects { get; set; }
    }

    public class Project
    {
        public string? Title { get; set; }
        public string? ImageUrl { get; set; }
        public List<string>? Description { get; set; }
        public List<string>? Technologies { get; set; }
    }

    public class EducationSection
    {
        public List<Education>? Degrees { get; set; }
    }

    public class Education
    {
        public string? Degree { get; set; }
        public string? Institution { get; set; }
        public string? Duration { get; set; }
    }

    public class CertificationsSection
    {
        public List<Certificate>? Certificates { get; set; }
    }

    public class Certificate
    {
        public string? Name { get; set; }
        public string? ImagePath { get; set; }
        public string? FullImagePath { get; set; }
        public string? Description { get; set; }
    }
}

