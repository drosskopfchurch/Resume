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
                        new Skill
                        {
                            Id = 2,
                            Name = "Middelware",
                            Description = "I have created my own middleware componenets, I understand how this works well.",
                            Proficiency = 5
                        },
                        new Skill
                        {
                            Id = 3,
                            Name = "C#",
                            Proficiency = 4,
                            Description = "Pretty familiar up to C# 7, have not used the features of 8 and 9 a whole lot yet."
                        },
                        new Skill
                        {
                            Id = 4,
                            Name = "Entity Framework",
                            Proficiency = 5,
                            Description = "I feel pretty expert in this field, I can often figure out complex queries that others can't."
                        },
                        new Skill
                        {
                            Id = 5,
                            Name = "Database Migrations",
                            Proficiency = 5,
                            Description = "I love code first migrations, and I feel like I am got this down to a science."
                        },
                        new Skill
                        {
                            Id = 6,
                            Name = "Async",
                            Proficiency = 4,
                            Description = "I use asynchronouse calls in most my methods.  I am pretty familiar with ways to make this run efficient."
                        },
                        new Skill
                        {
                            Id = 7,
                            Name = "List and Data Manipulation",
                            Proficiency = 5,
                            Description = "I undestand the many differences between each of the collection interfaces, I familiar with what is effecient and what is not. "
                        },
                        new Skill
                        {
                            Id = 8,
                            Name = "Unit Testing",
                            Proficiency = 4,
                            Description = "I have written many unit tests, I am master at the framework, but don't naturally do TDD"
                        },
                        new Skill
                        {
                            Id = 9,
                            Name = "Controller",
                            Proficiency = 5,
                            Description = "I am really familiar with the controllers, including the REST verbs, undestanding basic useage of best practices for developing controller endpoints"
                        },
                        new Skill
                        {
                            Id = 10,
                            Name = "Security",
                            Proficiency = 3,
                            Description = "I am pretty familiar Oauth, and securing endpoints with Oauth.  I am less familiar with other methods like SAML."
                        },
                        new Skill
                        {
                            Id = 11,
                            Name = "Design Patterns",
                            Proficiency = 2,
                            Description = "There is a lot of different design patterns to learn, I think practice many, but I need to know the names, and understanding the patterns. I do know Inversion of control, dipendency injection, single responsibility "
                        },
                    }
                };
            }
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
                        new Skill
                        {
                            Id = 13,
                            Name = "State Management",
                            Description = "I have a firm grasp on the different ways to manage state.  I understand useState and useContext well, but not redux.",
                            Proficiency = 4
                        },
                        new Skill
                        {
                            Id = 14,
                            Name = "NextJs",
                            Proficiency = 4,
                            Description = "I am pretty familiar with the NextJS routing framework, and how to use it. "
                        },
                        new Skill
                        {
                            Id = 15,
                            Name = "Components",
                            Proficiency = 5,
                            Description = "I really familiar with component structure, and when to create smart and dumb components."
                        },
                        new Skill
                        {
                            Id = 16,
                            Name = "NodeJs",
                            Proficiency = 2,
                            Description = "I have not mastered using and customizing nodejs.  I pretty much leave it as is when it comes in the starter."
                        },
                    }
                };
            }
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
                        new Skill
                        {
                            Id = 18,
                            Name = "Typescript",
                            Description = "I fill pretty proficient at type script, although I haven't used it in a couple year, I still remember a lot",
                            Proficiency = 4
                        },
                        new Skill
                        {
                            Id = 19,
                            Name = "Components",
                            Proficiency = 4,
                            Description = "I know and understand the component structure pretty well, a little rusty, but wouldn't take long to update my skillset."
                        },
                        new Skill
                        {
                            Id = 20,
                            Name = "State Management",
                            Proficiency = 4,
                            Description = "I love to use signal R with observables, I think it goes really well together. "
                        },
                        new Skill
                        {
                            Id = 21,
                            Name = "Routing",
                            Proficiency = 5,
                            Description = "Routing isn't to complicated in Angular, so I guess I can be an expert."
                        },
                    }
                };
            }
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
                        new Skill
                        {
                            Id = 23,
                            Name = "Css",
                            Description = "I am proficient, I can troubleshoot, and do most things in css, but there are people who are better than I.",
                            Proficiency = 3
                        },
                        new Skill
                        {
                            Id = 24,
                            Name = "HTML",
                            Proficiency = 4,
                            Description = "The HTML standard isn't to complicated, I think I am pretty familiar with it."
                        },
                        new Skill
                        {
                            Id = 25,
                            Name = "Javascript",
                            Proficiency = 4,
                            Description = "I know Javascript fairly well, and understand the functional principles of the language."
                        },
                        new Skill
                        {
                            Id = 26,
                            Name = "Performance",
                            Proficiency = 5,
                            Description = "I understand best practices for minimization, using CDN to distribute static content, using Server Side Rending vs client side"
                        },
                    }
                };
            }
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
                        new Skill
                        {
                            Id = 28,
                            Name = "Pipelines",
                            Description = "I am pretty familiar with YAML, I could do better at using YAML templates",
                            Proficiency = 4
                        },
                        new Skill
                        {
                            Id = 30,
                            Name = "Repos",
                            Proficiency = 4,
                            Description = "I understand how to creat, and use git repos.  I love using gitflow methodology"
                        },
                        new Skill
                        {
                            Id = 31,
                            Name = "Boards",
                            Proficiency = 4,
                            Description = "I understand how to manage sprints, and boards."
                        },
                    }
                };
            }
        }

        public static Skill AngularJs
        {
            get => new Skill
            {
                Name = "AngularJs"
            };
        }
        public static Skill TFS
        {
            get => new Skill
            {
                Name = "TFS"
            };
        }
        public static Skill ASPNET
        {
            get => new Skill
            {
                Name = "ASPNET"
            };
        }
        public static Skill WebDriver
        {
            get => new Skill
            {
                Name = "Web Driver (UI Automation)"
            };
        }
        public static Skill Trainer
        {
            get => new Skill
            {
                Name = "Trainer"
            };
        }
        public static Skill Leader
        {
            get => new Skill
            {
                Name = "Leader"
            };
        }
        public static Skill Automation
        {
            get => new Skill
            {
                Name = "Automation"
            };
        }
        public static Skill OutsideTheBoxThinking
        {
            get => new Skill
            {
                Name = "Outside the box thinking"
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
                Proficiency = 5
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
        public static IList<Skill?> All => typeof(Skills)
                                            .GetFields()
                                            // .Where(p => 
                                            //     p != null &&  
                                            //     p.GetValue(null) != null && 
                                            //     p.GetValue(null).GetType().Equals(typeof(Skill)))
                                            .Select(p => (Skill) p.GetValue(null))
                                            .ToList();
    }
}