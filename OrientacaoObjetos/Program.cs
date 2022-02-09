using OrientacaoObjetos.ContentContext;
using System.Collections.Generic;
using System;
using System.Linq;
using OrientacaoObjetos.SubscriptionContext;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo OOP", "orientacao_objetos"));
            articles.Add(new Article("Artigo C#", "c_sharp"));
            articles.Add(new Article("Artigo ASP.NET", "aspnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OO", "fundamentos-oo");
            var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");

            var careerItem = new CareerItem(1, "Começe por aqui", "", null);
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem3);

            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);

                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} = {notification.Message}");
                    }
                }
            }

            var paypalSubscription = new PaypalSubscription();
            var student = new Student();
            student.CreateSubscription(paypalSubscription);
        }
    }
}
