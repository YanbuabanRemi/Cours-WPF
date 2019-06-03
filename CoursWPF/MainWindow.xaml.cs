using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoursWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // WPF : C'est la spécification graphique de Microsoft .NET 3.0.
            // Il intègre le langage XAML (qui permet d'écrire plus facilement les fenètre) qui permet de l'utiliser d'une manière proche d'une page HTML

            // Pour créer une appli WPF => nouveau projet => Application WPF(.NET Framwork)

            // (.xaml)xmlns défini l'espace-noms de type de balise que l'on va utiliser
            // "xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation""

            // (App.xaml) l'espace-noms "StartupUri=xxxxx" est la première fenètre qui s'ouvre quand on lance le projet

            // Un projet est reparti entre plusieurs feuille XAML qui représente les différents fenètres de l'application
            // Chaque fichier XAML contient 2 fichiers :
            // - Un fichier .xaml ou on écrit le code lié au "design" de l'application, la ou on retrouve tous les composants de la fenètre
            // - Un fichier "caché" .xaml.cs qui contient du code C# qui défini les outils que l'on utilise dans le fichier .xaml
            //   (Si on creer un bouton, il sera ecrit un code du style "Bouton B = new Bouton()" ensuite on pourra acceder et utiliser B
        }

        // partial permet de pouvoir écrire le nom d'un classe dans plusieurs fichiers différents
        public partial class xxxxx
        {

        }
    }
}
