using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new PortfolioViewModel
            {
                AboutMe = GetAboutMe(),
                Skills = GetSkills(),
                Experience = GetExperience(),
                Projects = GetProjects(),
                Education = GetEducation(),
                Certifications = GetCertifications()
            };

            return View(model);
        }

        private static AboutMe GetAboutMe()
        {
            return new AboutMe
            {
                Title = "Portfolio",
                Name = "Prabhakaran S",
                JobTitle = ".NET Developer",
                Description = "Versatile .NET Developer with over 2 years of hands-on experience crafting robust backend systems, managing on-premise deployments, and implementing DevOps pipelines. Committed to writing clean, maintainable code and continuously evolving with the latest in software engineering.",
                Email = "prabhakarandotnetdeveloper@gmail.com",
                LinkedInUrl = "https://www.linkedin.com/in/prabhakaran-s-b0011a21a/",
                ProfileImagePath = "/Images/Mine.jpg"
            };
        }

        private static SkillsSection GetSkills()
        {
            return new SkillsSection
            {
                SkillCategories =
                [
                    new SkillCategory { Name = "Languages", IconClass = "fas fa-code", Skills = ["C#", "JavaScript", "TypeScript", "Python", "SQL"]},
                    new SkillCategory { Name = "Backend & Frameworks", IconClass = "fas fa-cogs", Skills = ["ASP.NET Core, MVC", ".NET 8, Web API", "Entity Framework, ADO.NET", "Django, Flask", "Microservices Architecture"]},
                    new SkillCategory { Name = "Frontend", IconClass = "fas fa-paint-brush", Skills = ["HTML5, CSS3, Sass", "Bootstrap, Tailwind CSS", "Angular", "Razor Pages"]},
                    new SkillCategory { Name = "Databases", IconClass = "fas fa-database", Skills = ["SQL Server", "MySQL, PostgreSQL", "SQLite", "Redis (basics)"]},
                    new SkillCategory { Name = "DevOps & Cloud", IconClass = "fas fa-cloud", Skills = ["Azure (App Service, Functions)", "Docker, Docker Compose", "CI/CD (GitHub Actions, Azure DevOps)", "On-Premise Hosting"]},
                    new SkillCategory { Name = "Logging & Monitoring", IconClass = "fas fa-clipboard-list", Skills = ["Serilog", "NLog", "Microsoft.Extensions.Logging", "Seq", "Application Insights"]},
                    new SkillCategory { Name = "Tools & Utilities", IconClass = "fas fa-tools", Skills = ["Git, GitHub, GitLab", "Visual Studio, VS Code", "Swagger, Postman", "IIS, Kestrel, Nginx (basic)"]},
                    new SkillCategory { Name = "Security & Authentication", IconClass = "fas fa-shield-alt", Skills = ["JWT Authentication", "AES Encryption (Static & Dynamic Keys)", "Role-Based Authorization", "HTTPS, CORS Policies"]},
                    new SkillCategory { Name = "Soft Skills & Communication", IconClass = "fas fa-comments", Skills = ["Team Collaboration", "Requirement Analysis", "Technical Documentation", "Client Communication"]}
                ]
            };
        }

        private static ExperienceSection GetExperience()
        {
            return new ExperienceSection
            {
                Experiences =
                [
                    new Experience
                    {
                        DateRange = "Mar 2025 - Present",
                        Company = "Aetram InfoTech",
                        Position = "Software Developer",
                        Responsibilities =
                        [
                            "Fullstack MVC.NET Core development",
                            "Secured the site using JWT tokens for authentication and authorization."
                        ]
                    },
                    new Experience
                    {
                        DateRange = "Feb 2023 - Feb 2025",
                        Company = "Constient Global",
                        Position = "Jr. .NET Developer",
                        Responsibilities =
                        [
                            "Developed and maintained SBI Demat & Mutual Fund systems.",
                            "Optimized site performance and implemented Role-Based Access Control (RBAC).",
                            "Secured the site using JWT tokens for authentication and authorization."
                        ]
                    },
                    new Experience
                    {
                        DateRange = "Nov 2021 - Feb 2023",
                        Company = "Networkz Systems",
                        Position = "Technical Trainer",
                        Responsibilities =
                        [
                            "Handled classes and training sessions on full-stack development.",
                            "Specialized in ASP.NET Core MVC framework and Python (Django, Flask)."
                        ]
                    }
                ]
            };
        }

        private static ProjectsSection GetProjects()
        {
            return new ProjectsSection
            {
                Projects =
                [
                    new Project
                    {
                        Title = "SBI Demat Account Opening & Backoffice Verification System",
                        ImageUrl = "https://opendemataccount.sbisecurities.in/SBIDIYV1/assets/images/SBINEW/LogoWeb.webp",
                        Description =
                        [
                            "Developed using ASP.NET MVC, SQL Server, and RESTful API integration.",
                            "Integrated third-party services like Digilocker, NSDL PennyDrop & eSign, CDSL eSign, SETU Reverse PennyDrop, CVL, NDML KRA, and more.",
                            "Deployed the application on on-premises IIS servers.",
                            "Implemented JWT-based middleware authentication and authorization.",
                            "Used background tasks and async controllers for document verification workflows.",
                            "Optimized database and API logic to improve performance by over 30%.",
                            "Applied logging with Serilog and exception handling middleware."
                        ],
                        Technologies = ["ASP.NET", "SQL Server", "JWT", "IIS", "ADO.Net", "Task Scheduler Service"]
                    },
                    new Project
                    {
                        Title = "Mutual Fund Account Opening – Absolute Broking",
                        ImageUrl = "https://www.absolutebroking.com/assets/images/Group.png",
                        Description =
                        [
                            "Developed account opening and KYC verification modules using .NET Core and MySQL.",
                            "Integrated services like Digilocker, Digio eSign, and KRA verification APIs.",
                            "Built mutual fund investment platform in collaboration with NSE services.",
                            "Used Redis for caching and improved load time on high-traffic pages.",
                            "Implemented role-based access control (RBAC) and token-based security using JWT.",
                            "Applied layered architecture with dependency injection and repository patterns."
                        ],
                        Technologies = [".NET Core", "MySQL", "Redis", "RBAC", "JWT", "HTML", "CSS", "JQuery", "Javascript", "Bootstrap"]
                    },
                    new Project
                    {
                        Title = "Aetram Trades MU",
                        ImageUrl = "/Images/A1.jpg",
                        Description =
                        [
                            "Built a demat account onboarding platform using .NET Core MVC and Razor pages.",
                            "Implemented JWT security with custom encryption/decryption (ENC & DESC) using dynamic keys and IVs.",
                            "Utilized Redis for efficient session and token caching.",
                            "Applied middleware to control request pipelines and manage cross-cutting concerns."
                        ],
                        Technologies = [".NET Core (MVC)", "Razor Pages", "JWT", "Microsoft SQL", "Redis", "HTML", "CSS", "JQuery", "Javascript", "Bootstrap", "ADO.Net", "Linq"]
                    }
                ]
            };
        }

        private static EducationSection GetEducation()
        {
            return new EducationSection
            {
                Degrees =
                [
                    new Education
                    {
                        Degree = "B.Sc. Computer Science",
                        Institution = "N.M.S.S.V.N College, Madurai",
                        Duration = "Kamarajar University, 2019"
                    }
                ]
            };
        }

        private static CertificationsSection GetCertifications()
        {
            return new CertificationsSection
            {
                Certificates =
                [
                    new Certificate
                    {
                        Name = ".NET Core & Web API",
                        ImagePath = "/Images/tambSqLI.png",
                        FullImagePath = "/Images/SqLI.png",
                        Description = "SQL Basic Certificate"
                    },
                    new Certificate
                    {
                        Name = "Python Full Stack",
                        ImagePath = "/Images/TambProblemS.png",
                        FullImagePath = "/Images/ProblemS.png",
                        Description = ".NET Core Certificate"
                    }
                ]
            };
        }

        [HttpPost]
        public ActionResult Contact(string name, string email, string message)
        {
            
            TempData["Message"] = "Thank you for contacting me!";
            return RedirectToAction("ThankYou");
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
