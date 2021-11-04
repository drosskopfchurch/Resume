using System.Collections.ObjectModel;
using Resume.UI.Models;

namespace Resume.UI.Data
{
    public static class Experiences
    {
        public static Experience ClearanceSystem
        {
            get => new Experience
            {
                Name = "Clearance System Application",
                Description = @"This is the first solution I was a lead engineer from the start.  Led a team of 4-5 engineers. 
                                This system helps manage the ecclesiastical clearances for Church Education Employees.
                                Required multiple service to service integrations, very complex workflows, and questionnaire management.
                                Written in .net Core, Microsoft Sql, Code First Migrations, and React.",
                Position = Positions.SoftwareEngineer4,
                Skills = new Collection<Skill>()
                {
                    Skills.React, 
                    Skills.DotNet, 
                    Skills.AzureDevOps    
                }
            };
        }
        public static Experience RecreationPropertiesApplication
        {
            get => new Experience
            {
                Name = "Recreational Properties Application",
                Description = @"On this application I started as a grunt, and ended as the lead engineer.  Led a team of 2-4 engineers. 
                                This system helped take reservations for over 100 recreational properties.  The system being able to support, 
                                very complex black out dates, pricing structures, amentities, mapping, reservation types (ie Young Women, Family, Ward), 
                                content management, and correlation support.  Integrated with many different applications.  
                                
                                Written in .net Core, Microsoft Sql, Code First Migrations, Signal R and Angular.",
                Position = Positions.SoftwareEngineer4,
                Skills = new Collection<Skill>()
                {
                    Skills.Angular, 
                    Skills.DotNet, 
                    Skills.AzureDevOps    
                }
            };
        }
        public static Experience SpaceManagementApplication
        {
            get => new Experience
            {
                Name = "Space Management Application",
                Description = @"On this application, I started as a grunt, but ended as a lead. This application helped the Church Headquarters 
                                manage space for the 34+ offices the church has.  Integrating with a product from Enstoa, that took architecture drawing, 
                                and converted it to space data, that we used to overlay the 
                                architecture drawings, allowing us to suplement with metadata including, employee data, space types, organizations.  

                                Had a complex assignment algorythm, security requirements, and reporting feature sets.   
                                
                                Written in .net Core, Microsoft Sql, Database Project, AngularJs",
                Position = Positions.SoftwareEngineer3,
                Skills = new Collection<Skill>()
                {
                    Skills.AngularJs, 
                    Skills.DotNet, 
                    Skills.AzureDevOps    
                }
            };
        }
        public static Experience ReverseEngineerUnifier
        {
            get => new Experience
            {
                Name = "Reverse Engineer Unifier",
                Description = @"Initially, I reversed engineer the unifier project, so I could automate the testing of our implementation of the application. 
                                As we progressed, they gave me small team, 1 engineer, Qa, PM. I lead the team in building unique tools to compensate
                                for many fo the short comings unifier had, including: translation support, and a configuration comparison tool
                                
                                As the project was close to failure, because of the lack of integration support my reversed engineering knowledge was critical 
                                in keeping the project going.  We switch Unifier to a configuration, workflow management, and back end support, but created a new UI, 
                                and supplemented with custom API, that combined unifier with other internal services. 
                                
                                After heading up a proof of concept, we were able to obtaint he additional funding, to redo our implementation of Unifier.",
                Position = Positions.SoftwareEngineer4,
                Skills = new Collection<Skill>()
                {
                    Skills.GeneralWebDevelopment, 
                    Skills.ASPNET, 
                    Skills.TFS    
                }
            };
        }
        public static Experience AutomationTrainer
        {
            get => new Experience
            {
                Name = "Church Automation Classes",
                Description = @"In an effort to increase the level of automation and technical knowledge among QA in the Church.  
                I taught a series of Webdriver classes for 3 years.  Each class having the attendance of around 15 engineers.  
                Many groups that were not automating before my classes, and were automating significantly more after.

                It's important to note that I was not asked to do this, I saw the need, and just did it.  
                
                I also led a Quality Assurance Community of Practice for a while.",
                Position = Positions.QualityAssuranceEngineer3,
                Skills = new Collection<Skill>()
                {
                    Skills.WebDriver, 
                    Skills.Trainer, 
                    Skills.Leader    
                }
            };
        }
        public static Experience DotNetLearningGroup
        {
            get => new Experience
            {
                Name = ".Net Core Learning Group",
                Description = @"When .net Core first came out, I organized and led a learning group to help engineers learn, and use .net core.  
                                I presented many times to very senior level engineers and architects, but also allowing other engineers to contribute.  
                                We convered many important subjects like code first, front end templates, middleware, configuration and startup, 
                                c# 7 features, authentication, etc..
                                
                                Its important to note I was not assigned to do this for the Church, I saw a need, and just did it.  
                                ",
                Position = Positions.SoftwareEngineer3,
                Skills = new Collection<Skill>()
                {
                    Skills.DotNet, 
                    Skills.Trainer, 
                    Skills.Leader    
                }
            };
        }
        public static Experience AngularLearningGroup
        {
            get => new Experience
            {
                Name = "Angular Learning Group",
                Description = @"When Angular 2 first came out, I led learning group to help engineers learn, and use angular 2.  I presented many times
                                but also focused on allowing other engineers to contribute.  We focused on various topics like, routing, components, rxjs, 
                                material IO, translation, SSR, configuration etc... 
                                
                                Its important to note I was not assigned to do this for the Church, I saw a need, and just did it.  
                                ",
                Position = Positions.SoftwareEngineer3,
                Skills = new Collection<Skill>()
                {
                    Skills.Angular, 
                    Skills.Trainer, 
                    Skills.Leader    
                }
            };
        }
        public static Experience ICSAutomation
        {
            get => new Experience
            {
                Name = "Church Automation",
                Description = @"In the Church, I grew in my atomation skillset quite a bit.  But as I grew I constantly focused on helping other 
                                engineers build in their skillset.  I started in the Church as a mid level automator, but with in a couple years I had
                                mastered the art of automation, having created many automation suites, including solutions integrating with TFS. 

                                I had created a solution, that would build in TFS, deploy to Automation Servers, and integrated with TFS Test Suites, so 
                                I could click on a test, and run it, have it run on server, and report the results, including screen shots back to TFS.  
                                This was a pretty slick, but complex solution.  
                                ",
                Position = Positions.QualityAssuranceEngineer3,
                Skills = new Collection<Skill>()
                {
                    Skills.DotNet, 
                    Skills.WebDriver,
                    Skills.Automation
                }
            };
        }
        public static Experience CISAutomation
        {
            get => new Experience
            {
                Name = "CIS Automation",
                Description = @"When I started QA at CIS, we didn't have any automation, and the last and only QA engineer we had, left becuase 
                                CIS would not invest in an expensive automation suite.  I knew nothing about automation, and really scripting in general. 
                                I researched many different solutions for automation scripting, until finally landing on Selenium. I quickly learned to automate,
                                and start learning c# and ASP.NET.  One of the harder things I had to figure out, was how to download, and parse a dynamically
                                generated PDF to make sure it had the correct information.  
                                ",
                Position = Positions.QualityAssuranceEngineer,
                Skills = new Collection<Skill>()
                {
                    Skills.DotNet, 
                    Skills.Automation,
                }
            };
        }
        public static Experience OutsideTheBoxSolutions_PDF
        {
            get => new Experience
            {
                Name = "Outside the box solutions (PDF Printing)",
                Description = @"At CIS, they were printing chain of custody forms for the illegal drug testing.  The one feature 
                                that was critical for this to work, was a pdf that would render silently, and automatically print to the connected 
                                printer.  It was important that the PDF had no chance of being modified. Our senior developers had said 
                                it was impossible.  Although I was not a software developer, a part of me believed this could be done.  
                                I knew that PDF had some javascript capability, and after a few days of playing around, I was able to inject a script
                                into a PDF that would silent open, and print.  

                                I don't think It made me popular with the developers, but it was a critical need for the business. Significantly changing the
                                value of the business, and allowing to change the industry. I even got a bonus for the out of box thinking. 
                                ",
                Position = Positions.QualityAssuranceEngineer,
                Skills = new Collection<Skill>()
                {
                    Skills.DotNet, 
                    Skills.GeneralWebDevelopment,
                    Skills.OutsideTheBoxThinking
                }
            };
        }
        public static Experience ServerMonitoring
        {
            get => new Experience
            {
                Name = "Server Monitoring",
                Description = @"At CIS, they had some very fragile, but important processes.  The solution management came up with was to 
                                get technical support to login and check the servers every hour.  We found on many occassions this was not 
                                sufficient, often they would foget to check, and we would find services would still get locked up, and 
                                results would stop reporting for hours without technical support checking.  Although not in my realm of 
                                responsiblity, I had the idea of creating monitoring service.  This would run some automation to login 
                                to each of the applications and ensure they are running, it would also check various metrics to determine that
                                things are getting processed.  It would email the technical support to make them aware of issues.  I also created 
                                a sytem tray, that would popup a notification if there was an issue with any of the services.  
                                ",
                Position = Positions.QualityAssuranceEngineer,
                Skills = new Collection<Skill>()
                {
                    Skills.DotNet, 
                    Skills.Automation,
                    Skills.OutsideTheBoxThinking
                }
            };
        }
        public static Experience WorkOrganizingAndTracking
        {
            get => new Experience
            {
                Name = "Work Organizing and Tracking",
                Description = @"At CIS, they had no good way of organizing work.  Many bug/request tracking systems had been created with Access, 
                                but organziation adoption was slow, and often the access applications would get corrupted.  As a QA, a way of reporting 
                                and tracking bugs was really important.  Although the business didn't agree they needed it, in my off time, I researched 
                                some good open source solutions that we could implement.  I was able to find an implement a .net open sourced web based solution, 
                                customizing it to our needs, with instant adoption accross product development, technical support, and QA.  

                                This became a core application to supporting our business.  
                                ",
                Position = Positions.QualityAssuranceEngineer,
                Skills = new Collection<Skill>()
                {
                    Skills.DotNet, 
                    Skills.Automation,
                    Skills.OutsideTheBoxThinking
                }
            };
        }
        public static Experience EnhancingTechnicalSupportCapabilities
        {
            get => new Experience
            {
                Name = "Enhancing Technical Support Capabilities",
                Description = @"As a technical support representative, I was able to find certain things developers were doing, and adopted to them 
                                to allow technical support handle them.  This includes fixing back log issues with our backend processes, learning 
                                to replicate SQL Servers, helping to set up customers SQL Servers, to host their own application.  Helping client 
                                create and run custom SQL reports.  

                                Many of these services were charged as developer hours, and provided an extra revenue source to our technical support 
                                team.   
                                ",
                Position = Positions.QualityAssuranceEngineer,
                Skills = new Collection<Skill>()
                {
                    Skills.SqlServer,
                    Skills.OutsideTheBoxThinking
                }
            };
        }
        public static Experience FormFoxBusinessAnalysis
        {
            get => new Experience
            {
                Name = "Form Fox Business Analysis",
                Description = @"As a Quality Engineer, I provided solutions, and features for the application.  I would create detailed technical 
                                designs for developers in Belarus to work on.  I was very influential in the design of the product. 
                                ",
                Position = Positions.QualityAssuranceEngineer,
                Skills = new Collection<Skill>()
                {
                    Skills.BusinessAnalysis,
                }
            };
        }
        public static Experience WaptLoadTesting
        {
            get => new Experience
            {
                Name = "WAPT Load Testing",
                Description = @"When I started as a QA Engineer, we had no solution for Load Testing.  I researched many different solutions, and after
                                considering all of the different costs, I settled on WAPT, which allowed me to simulate a load of a few thousand users, 
                                for less than a couple hundred dollars.  I then taught myself how to do load testing.  After a couple weeks, I was able
                                to recreate tests, and easily reproduce serious performance issues we were having.  This became an invaluable skill. 
                                ",
                Position = Positions.QualityAssuranceEngineer,
                Skills = new Collection<Skill>()
                {
                    Skills.LoadTesting,
                }
            };
        }
        public static Experience SilkLoadTesting
        {
            get => new Experience
            {
                Name = "Silk Load Testing",
                Description = @"At the church, I they had a license to Silk Performer, which allowed me to simulate UI loads of hundreds of users, 
                                and HTTP calls of thousands of users.   I learned how to integrate it with database, so we can more accurately 
                                simulate a proper load.  This also helped to solve some very critical performance issues, and server outages we were having. 
                                I could usually script something useful out in 3-4 hours.  Helping developers find and identify issues in non production 
                                environments.  
                                ",
                Position = Positions.QualityAssuranceEngineer3,
                Skills = new Collection<Skill>()
                {
                    Skills.LoadTesting,
                }
            };
        }
        public static Experience VisualStudioLoadTesting
        {
            get => new Experience
            {
                Name = "Visual Studio Load Testing",
                Description = @"At the church, I also became an expert at Visual Studio Load Testing.   This was also a good service, that would 
                                allow us to simulate about 1-2k users per machine, and spin up a buch of VM's to run automation.  This also helped
                                us to solve a variety of performance, and memory leaks we had in production.  
                                ",
                Position = Positions.QualityAssuranceEngineer3,
                Skills = new Collection<Skill>()
                {
                    Skills.LoadTesting,
                }
            };
        }
        public static Experience ReservationPerformance
        {
            get => new Experience
            {
                Name = "Reservation Performance",
                Description = @"In recreational properties we had a lot of complex reservation rules, this made checking availability of 1,000 campsites very difficult.  
                                It also made it very diffult to check a month's worth of a availability over the course of a month, for specific property with 130 campsites. 
                                We had a sr. Engineer who worked on the queries for months, and was able to get them down to 30-90 seconds.  I spent about a month reworking
                                the queries, and was able to bring it down to 3 seconds.  This was a huge performance increase.

                                This used multiple functions, stored procedures, temp tables, and custom views.  A lot of query analysis, and reading plans. 
                                ",
                Position = Positions.QualityAssuranceEngineer3,
                Skills = new Collection<Skill>()
                {
                    Skills.Sql,
                }
            };
        }
        public static Experience ClearanceReportingAndDataAnalysis
        {
            get => new Experience
            {
                Name = "Clearance Reporting and Data Analysis",
                Description = @"After the clearance application was launched, there was a lot of information we need to know.  How many clearances were
                                being performed? How quickly were they being peformed? Which step to the longest? What questions took the longest to answer?
                                When we built the application, we put a lot of thought to add a lot of audit data.  This was critical to answering a lot of 
                                the vital questions we had, and being able to predict and understand user behavior.  This required a variety of complex 
                                query writting, and data analysis.  In the end the information I presented, helped us to develop some very critical features, 
                                that decreased the time it took to get a clearance done.  
                                ",
                Position = Positions.SoftwareEngineer4,
                Skills = new Collection<Skill>()
                {
                    Skills.Sql,
                }
            };
        }
        public static Experience ClearanceApplicationSolutioning
        {
            get => new Experience
            {
                Name = "Clearance Application Solutioning",
                Description = @"When it comes to any application I work on, I go far and beyond to understand the business need.  I do this 
                                by shadowing the business partner, walking through their process, asking plenty of question, diagraming the process.  I
                                find that often, what the customer/business ask for is often not what they need.  Often what they need is far simpler 
                                than what they are asking for.  
                                
                                Once I feel like I understand the application, I work with an IXD to create the features that we needed to support 
                                the business.  I then have the business review the mock ups the IXD created, and further clarify, redifine, and simplify
                                the process.   This has lead to a very successful product, with a very pleased business partner. As the lead on the project, I 
                                like to be in charge of the design, architecting, and overall solutions of the application.
                                ",
                Position = Positions.SoftwareEngineer4,
                Skills = new Collection<Skill>()
                {
                    Skills.BusinessAnalysis,

                }
            };
        }
        public static IList<Experience> All()
        {
            return typeof(Experiences)
            .GetProperties()
            .Where(p =>
                        p != null &&
                        p.GetValue(null) != null &&
                        p.GetValue(null).GetType().Equals(typeof(Experience)))
                    .Select(p => (Experience)p.GetValue(null))
                    .ToList();

        }
        public static IList<Experience> GetBySkill(string skill)
        {
            return All()
                    .Where(e => 
                        e.Skills.Any(s => s.Name == skill))
                    .ToList();
        }
    }
}