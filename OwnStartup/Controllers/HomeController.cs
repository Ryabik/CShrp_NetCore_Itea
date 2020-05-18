using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace OwnStartup.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }
        /*3. В этом же проекте (который создан по шаблону Empty Project), 
         * добавьте папку с Controllers и класс HomeController 
         * добавьте туда метод Index с возвращаемым типом string. 
         * (пока что результат этого метода будет возвращаться 
         * прямо на страницу браузера, View создавать не нужно)
         * Попробуйте вызвать метод по адресу 
            https://localhost:{port}/Home/Index, 
            где port - это порт на котором работает ваше приложение.

4. Добавьте в методы Configure и ConfigureServices
класса вызов нужных методов для того чтоб работал вызов 
созданного вами метода из контроллера. 
Не стесняйтесь копировать из проекта созданного по шаблону MVC, главное запомните, каких методов не хватало для правильного вызова метода в контроллере.*/
    }
}
