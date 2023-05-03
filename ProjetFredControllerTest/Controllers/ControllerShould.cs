using Microsoft.AspNetCore.Mvc;
using PremierProjetASP.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFredControllerTest
{
    internal class ControllerShould
    {
        public void Numero1ShowText()
        {
            // Instancier la class du controlleur a tester
            var homeController = new HomeController();
            // Appeler la methode d'action qu'on veux tester
            var result = homeController.Numero1();
            // Vérifier le type du résultat
            var textResult = Assert.IsType<string>(result);
        }
        public void Numero2ShowContent()
        {
            // Instancier la class du controlleur a tester
            var homeController = new HomeController();
            // Appeler la methode d'action qu'on veux tester
            var result = homeController.Numero2();
            // Vérifier le type du résultat
            var textResult = Assert.IsType<ContentResult>(result);
        }
        public void Numero3ShowView()
        {
            // Instancier la class du controlleur a tester
            var homeController = new HomeController();
            // Appeler la methode d'action qu'on veux tester
            var result = homeController.Numero3();
            // Vérifier le type du résultat
            var textResult = Assert.IsType<ViewResult>(result);
        }
        public void Numero4ShowFile()
        {
            // Instancier la class du controlleur a tester
            var homeController = new HomeController();
            // Appeler la methode d'action qu'on veux tester
            var result = homeController.Numero4();
            // Vérifier le type du résultat
            var textResult = Assert.IsAssignableFrom<ViewResult>(result);
        }
        public void Numero5ShowContent()
        {
            // Instancier la class du controlleur a tester
            var homeController = new HomeController();
            // Appeler la methode d'action qu'on veux tester
            var result = homeController.Numero4();
            // Vérifier le type du résultat
            var textResult = Assert.IsType<ContentResult>(result);
        }
        public void Numero6Showtext()
        {
            // Instancier la class du controlleur a tester
            var homeController = new HomeController();
            // Appeler la methode d'action qu'on veux tester
            var result = homeController.Numero4();
            // Vérifier le type du résultat
            var textResult = Assert.IsType<string>(result);
        }
    }
}
