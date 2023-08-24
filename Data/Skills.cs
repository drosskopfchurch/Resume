using Resume.UI.Models;

namespace Resume.UI.Data
{
    public static class Skills
    {
        public static Skill DotNet
        {
            get
            {
                return new Skill
                {
                    Id = 1,
                    Name = ".Net",
                    Proficiency = 5,
                    Skills = new List<Skill>()
                    {
                        Middelware,
                        CSharp,
                        EntityFramework,
                        DatabaseMigrations,
                        Async,
                        ListAndDataManipulation,
                        UnitTesting,
                        Controller,
                        Security,
                        DesignPatterns,
                    }
                };
            }
        }
        public static Skill Middelware
        {
            get => new Skill
            {
                Id = 2,
                Name = "Middelware",
                Description = "I have created my own middleware componenets, I understand how this works well.",
                Proficiency = 5,

            };
        }
        public static Skill CSharp
        {
            get => new Skill
            {
                Id = 3,
                Name = "C#",
                Proficiency = 4,
                Description = "Pretty familiar up to C# 7, have not used the features of 8 and 9 a whole lot yet.",

            };
        }
        public static Skill EntityFramework
        {
            get => new Skill
            {
                Id = 4,
                Name = "Entity Framework",
                Proficiency = 5,
                Description = "I feel pretty expert in this field, I can often figure out complex queries that others can't.",

            };
        }
        public static Skill DatabaseMigrations
        {
            get => new Skill
            {
                Id = 5,
                Name = "Database Migrations",
                Proficiency = 5,
                Description = "I love code first migrations, and I feel like I am got this down to a science.",

            };
        }
        public static Skill Async
        {
            get => new Skill
            {
                Id = 6,
                Name = "Async",
                Proficiency = 4,
                Description = "I use asynchronouse calls in most my methods.  I am pretty familiar with ways to make this run efficient.",

            };
        }
        public static Skill ListAndDataManipulation
        {
            get => new Skill
            {
                Id = 7,
                Name = "List and Data Manipulation",
                Proficiency = 5,
                Description = "I undestand the many differences between each of the collection interfaces, I familiar with what is effecient and what is not. ",

            };
        }
        public static Skill UnitTesting
        {
            get => new Skill
            {
                Id = 8,
                Name = "Unit Testing",
                Proficiency = 4,
                Description = "I have written many unit tests, I am master at the framework, but don't naturally do TDD",

            };
        }
        public static Skill Controller
        {
            get => new Skill
            {
                Id = 9,
                Name = "Controller",
                Proficiency = 5,
                Description = "I am really familiar with the controllers, including the REST verbs, undestanding basic useage of best practices for developing controller endpoints",

            };
        }
        public static Skill Security
        {
            get => new Skill
            {
                Id = 10,
                Name = "Security",
                Proficiency = 3,
                Description = "I am pretty familiar Oauth, and securing endpoints with Oauth.  I am less familiar with other methods like SAML.",

            };
        }
        public static Skill DesignPatterns
        {
            get => new Skill
            {
                Id = 11,
                Name = "Design Patterns",
                Proficiency = 2,
                Description = "There is a lot of different design patterns to learn, I think practice many, but I need to know the names, and understanding the patterns. I do know Inversion of control, dipendency injection, single responsibility ",

            };
        }
        public static Skill React
        {
            get
            {
                return new Skill
                {
                    Id = 12,
                    Name = "React",
                    Proficiency = 4,
                    Skills = new List<Skill>()
                    {
                        ReactStateManagement,
                        NextJs,
                        ReactComponents,
                        NodeJs,
                    }
                };
            }
        }
        public static Skill ReactStateManagement
        {
            get => new Skill
            {
                Id = 13,
                Name = "State Management",
                Description = "I have a firm grasp on the different ways to manage state.  I understand useState and useContext well, but not redux.",
                Proficiency = 4,

            };
        }
        public static Skill NextJs
        {
            get => new Skill
            {
                Id = 14,
                Name = "NextJs",
                Proficiency = 4,
                Description = "I am pretty familiar with the NextJS routing framework, and how to use it. ",

            };
        }
        public static Skill ReactComponents
        {
            get => new Skill
            {
                Id = 15,
                Name = "Components",
                Proficiency = 5,
                Description = "I really familiar with component structure, and when to create smart and dumb components.",

            };
        }
        public static Skill NodeJs
        {
            get => new Skill
            {
                Id = 16,
                Name = "NodeJs",
                Proficiency = 2,
                Description = "I have not mastered using and customizing nodejs.  I pretty much leave it as is when it comes in the starter.",

            };
        }
        public static Skill Angular
        {
            get
            {
                return new Skill
                {
                    Id = 17,
                    Name = "Angular",
                    Proficiency = 3,
                    Description = "I was proficient at angular around v6, but it has been a couple years since I have worked in it.  So a little rusty. ",
                    Skills = new List<Skill>()
                    {
                        Typescript,
                        AngularComponents,
                        AngularStateManagement,
                        Routing,
                    }
                };
            }
        }
        public static Skill Typescript
        {
            get => new Skill
            {
                Id = 18,
                Name = "Typescript",
                Description = "I fill pretty proficient at type script, although I haven't used it in a couple year, I still remember a lot",
                Proficiency = 4,

            };
        }
        public static Skill AngularComponents
        {
            get => new Skill
            {
                Id = 19,
                Name = "Components",
                Proficiency = 4,
                Description = "I know and understand the component structure pretty well, a little rusty, but wouldn't take long to update my skillset.",

            };
        }
        public static Skill AngularStateManagement
        {
            get => new Skill
            {
                Id = 20,
                Name = "State Management",
                Proficiency = 4,
                Description = "I love to use signal R with observables, I think it goes really well together. ",

            };
        }
        public static Skill Routing
        {
            get => new Skill
            {
                Id = 21,
                Name = "Routing",
                Proficiency = 5,
                Description = "Routing isn't to complicated in Angular, so I guess I can be an expert.",

            };
        }
        public static Skill GeneralWebDevelopment
        {
            get
            {
                return new Skill
                {
                    Id = 22,
                    Name = "General Web Developement",
                    Proficiency = 4,
                    Description = "",
                    Skills = new List<Skill>()
                    {
                        Css,
                        HTML,
                        Javascript,
                        Performance,
                    }
                };
            }
        }
        public static Skill Css
        {
            get => new Skill
            {
                Id = 23,
                Name = "Css",
                Description = "I am proficient, I can troubleshoot, and do most things in css, but there are people who are better than I.",
                Proficiency = 3,

            };
        }
        public static Skill HTML
        {
            get => new Skill
            {
                Id = 24,
                Name = "HTML",
                Proficiency = 4,
                Description = "The HTML standard isn't to complicated, I think I am pretty familiar with it.",

            };
        }
        public static Skill Javascript
        {
            get => new Skill
            {
                Id = 25,
                Name = "Javascript",
                Proficiency = 4,
                Description = "I know Javascript fairly well, and understand the functional principles of the language."
            };
        }
        public static Skill Performance
        {
            get => new Skill
            {
                Id = 26,
                Name = "Performance",
                Proficiency = 5,
                Description = "I understand best practices for minimization, using CDN to distribute static content, using Server Side Rending vs client side",

            };
        }
        public static Skill AzureDevOps
        {
            get
            {
                return new Skill
                {
                    Id = 27,
                    Name = "Azure Dev Ops",
                    Proficiency = 4,
                    Description = "I have been a project manager level for a long time. But never a collection manager.",
                    Skills = new List<Skill>()
                    {
                        Pipelines,
                        Repos,
                        Boards,
                    }
                };
            }
        }

        public static Skill Boards
        {
            get => new Skill
            {
                Id = 31,
                Name = "Boards",
                Proficiency = 4,
                Description = "I understand how to manage sprints, and boards.",

            };
        }
        public static Skill Repos
        {
            get => new Skill
            {
                Id = 30,
                Name = "Repos",
                Proficiency = 4,
                Description = "I understand how to creat, and use git repos.  I love using gitflow methodology",

            };
        }
        public static Skill Pipelines
        {
            get => new Skill
            {
                Id = 28,
                Name = "Pipelines",
                Description = "I am pretty familiar with YAML, I could do better at using YAML templates",
                Proficiency = 4,

            };
        }
        public static Skill AngularJs
        {
            get => new Skill
            {
                Name = "AngularJs",
                Proficiency = 3,
                Description = "Haven't used it in years, I could, but pretty rusty. "
            };
        }
        public static Skill TFS
        {
            get => new Skill
            {
                Name = "TFS",
                Proficiency = 4,
                Description = "I have managed TFS projects, but never collections. I am very proficient as a user, just not an Admin"
            };
        }
        public static Skill ASPNET
        {
            get => new Skill
            {
                Name = "ASPNET",
                Proficiency = 3,
                Description = "It's been years since I have worked in .net 4-.  However I could get myself around."
            };
        }
        public static Skill WebDriver
        {
            get => new Skill
            {
                Name = "Web Driver (UI Automation)",
                Proficiency = 4,
                Description = "I am pretty proficient on Webdriver, although I don't use it all that much anymore, I still teach classes, and can create a project pretty quickly."
            };
        }
        public static Skill Leadership
        {
            get => new Skill
            {
                Name = "Leadership",
                Proficiency = 3,
                Description = "I have led small groups, I have yet to lead larger groups, well at least not having an official title.  I have led from behing a lot.",
                Skills = new List<Skill>(){
                    Trainer,
                }
            };
        }
        public static Skill Solutioning
        {
            get => new Skill
            {
                Name = "Solutioning",
                Proficiency = 5,
                Description = "I have come up with some very awesome solutions, to some very complex issues.",
                Skills = new List<Skill>(){
                    OutsideTheBoxThinking,
                    Troubleshooting
                }
            };
        }
        public static Skill Troubleshooting
        {
            get => new Skill
            {
                Name = "Troubleshooting",
                Proficiency = 5,
                Description = "I haven't come accross an issue I couldn't troubleshoot yet.",
                Skills = new List<Skill>(){
                }
            };
        }
        public static Skill Database
        {
            get => new Skill
            {
                Name = "Database",
                Proficiency = 4,
                Description = "I have good expereince in both Microsoft and Oracle SQL. Could use more experience in NoSql",
                Skills = new List<Skill>(){
                    OutsideTheBoxThinking,
                    Sql,
                    SqlServer,
                    Oracle
                }
            };
        }
        public static Skill Trainer
        {
            get => new Skill
            {
                Name = "Trainer",
                Proficiency = 4,
                Description = "I often put myself in position to do trainings, I believe I am getting better.  I often present at community of practices, and at times conferences."
            };
        }
        public static Skill AutomatedTesting
        {
            get => new Skill
            {
                Name = "Automated Testing",
                Proficiency = 4,
                Description = "I am pretty familiar with Automated Testing, including UI, and Load Testing.",
                Skills = new List<Skill>(){
                    WebDriver
                }
            };
        }
        public static Skill OutsideTheBoxThinking
        {
            get => new Skill
            {
                Name = "Outside the box thinking",
                Proficiency = 5,
                Description = "I have learened this is one of my Super Powers.  I think different then most, and that allows for some very great solutions."
            };
        }
        public static Skill SqlServer
        {
            get => new Skill
            {
                Name = "Sql Server",
                Proficiency = 4,
                Description = @"I have set up, replicated, tuned, maintained.  The only thing I haven't done a 
                                lot of is user management.  There are probably some server admin stuff I am not as 
                                familiar with."
            };
        }
        public static Skill Oracle
        {
            get => new Skill
            {
                Name = "Oracle",
                Proficiency = 3,
                Description = @"It's been a while, but I am familiar with PL SQL, and have decent expereience working with Oracle Databases."
            };
        }
        public static Skill Sql
        {
            get => new Skill
            {
                Name = "Sql",
                Proficiency = 5,
                Description = @"I am pretty talent with SQL, I have created various functions, stored procedures, and very complex queries.
                                I have many performance tricks to increase performance."
            };
        }
        public static Skill SoftwareDevelopmentProcess
        {
            get => new Skill
            {
                Name = "Software Development Process",
                Proficiency = 5,
                Description = "During the life of my career, I have formally or informally acted in every position of the software development process.",
                Skills = new List<Skill>(){
                    BusinessAnalysis,
                    SoftwareArchitect,
                    QualityAssurance,
                    ProjectManager
                }
            };
        }
        public static Skill QualityAssurance
        {
            get => new Skill
            {
                Name = "Quality Assurance",
                Proficiency = 5,
                Description = @"
                I have a lot of experience in software quality, including ui automation, load testing, and leading testing efforts.

                My thoughts on QA: 
                
                Sizing: It is important to right size the QA effort.  The amount of effort taken to verify code written to land an aircraft carrier, should not be the same effort used to test video game. 
                Unit Testing: I find a lot of unit test to be security theater. When I interview engineers, I ask them about unit testing.  Many will admit to creating 1,000's, but when I ask them how often those unit tests have caught or prevented bugs.  The answer is always nearly zero.  So is there value in unit testing? Yes, but not in the way you think. 

                When I talk to the same engineers about value.  They all noted that the unit test did help them think through what they were writing. They also noted that unit test added a lot of technical debt. 

                Conclusion: It seems to me the highest value is in writing the test, and then discarding it afterwards. Except for limited part of the application where it makes sense. 

                UI Testing: This is probably has the highest potential.  The problem with UI Testing is without proper guidance and education, UI testing ends up having a high false negative/positive rate.  Meaning test engineers spend most of their time tracing down why a test failed when it should have passed, and visa versa.  Writing stable UI test is an art, and one I feel familiar with. 

                
                ",
                Skills = new List<Skill>(){
                    AutomatedTesting,
                    LoadTesting
                }
            };
        }
        public static Skill ProjectManager
        {
            get => new Skill
            {
                Name = "Project Manager",
                Proficiency = 3,
                Description = "I have on many occassions taken on the role of Project Manager, in addition to my official role."
            };
        }
        public static Skill BusinessAnalysis
        {
            get => new Skill
            {
                Name = "Business Analysis",
                Proficiency = 5
            };
        }
        public static Skill SoftwareArchitect
        {
            get => new Skill
            {
                Name = "Software Architect",
                Proficiency = 4
            };
        }
        public static Skill LoadTesting
        {
            get => new Skill
            {
                Name = "Load Testing",
                Proficiency = 5,
                Skills = new List<Skill>(){
                    SilkPerformer,
                    WAPT,
                    VisualStudioLoadTesting
                }
            };
        }
        public static Skill SilkPerformer
        {
            get => new Skill
            {
                Name = "Silk Performer",
                Proficiency = 4
            };
        }
        public static Skill WAPT
        {
            get => new Skill
            {
                Name = "WAPT",
                Proficiency = 4
            };
        }
        public static Skill VisualStudioLoadTesting
        {
            get => new Skill
            {
                Name = "Visual Studio Load Testing",
                Proficiency = 4
            };
        }
        public static Skill DevOps
        {
            get => new Skill
            {
                Name = "Dev Ops",
                Proficiency = 3,
                Description = "I have never been an Application System Engineer, but I have filled when I needed to.",
                Skills = new List<Skill>(){
                    CloudFoundry,
                    YAML,
                    Powershell
                }
            };
        }
        public static Skill CloudFoundry
        {
            get => new Skill
            {
                Name = "Cloud Foundry",
                Proficiency = 3,
                Description = "I have never been an administrator, but I have deployed a variety of apps to cloud foundry, utilizing a variety of unique cloud foundry features."
            };
        }
        public static Skill YAML
        {
            get => new Skill
            {
                Name = "YAML",
                Proficiency = 4,
                Description = "I am fairly proficient in YAML scripting, including desigining, and templating."
            };
        }
        public static Skill Powershell
        {
            get => new Skill
            {
                Name = "Powershell",
                Proficiency = 4,
                Description = "I feel pretty confident in this skill.  I have used this a lot in creating deployment tools, developer tools, reporting, even automating manual functions"
            };
        }
        // public static IList<Skill> All =>
        //     new List<Skill>(){
        //         DotNet,
        //         React,
        //         Angular,
        //         GeneralWebDevelopment,
        //         AzureDevOps
        //     };
        public static IList<Skill> All() =>

            typeof(Skills)
            .GetProperties()
            .Where(p =>
                        p != null &&
                        p.GetValue(null) != null &&
                        p.GetValue(null).GetType().Equals(typeof(Skill)))
                    .Select(p => (Skill)p.GetValue(null))
                    .ToList();
        public static IList<Skill> AllParents() =>

            All()
            .Where(s => s.Skills.Any())
            .ToList();


    }
}