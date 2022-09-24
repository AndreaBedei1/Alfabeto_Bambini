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

namespace alfabeto
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int lettera; // Posizione della lettera nella matrice. 
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void matrice()
        {
            Random random = new Random();
            // Ritorna un numero casuale compreso tra 1 e 3
            int num = random.Next(0, 3);

            string source; // Stringa dove viene messo il codice, in cui il programma andrà a prendere l'immagine.
            string[,] nomi = new string[3, 21] { 
            {"Armadillo","Bacio","Cavolo","Dattero","Erba","Farfalla","Gambero","Hacker","Icona","Lanterna","Magnolia","Nuvola","Ortica","Piercing","Quadro","Razzo","Sole","Twister","Uva","Vespa","Zaino" },
            {"Alpaca","Banana","Capriolo","Dinosauro","Evidenziatore","Ferrari","Gelato","Habanero","Insalata Russa","Lago","Mercurio","Nano Da Giardino","Orca","Pesca","Quaderno","Rupe","Sale","Tesoro","Usignolo","Vaso","Zebra"},
            {"Ape","Basso","Carro","Dromedario","Evoluzione","Fabbro","Girino","Hotel","Iettatore","Lingua","Marmellata","Nespole","Orchidea","Pulce","Questura","Rana","Scivolo","Tappeto Elastico","Uncino","Vassoio","Zerbino"}
            }; // Matrie con tutti i nomi delle foto.

        

            string[,] matLettere = new string[3, 21]{
            {"a1","b1","c1","d1","e1","f1","g1","h1","i1","l1","m1","n1","o1","p1","q1","r1","s1","t1","u1","v1","z1" },
            {"a2","b2","c2","d2","e2","f2","g2","h2","i2","l2","m2","n2","o2","p2","q2","r2","s2","t2","u2","v2","z2" },
            {"a3","b3","c3","d3","e3","f3","g3","h3","i3","l3","m3","n3","o3","p3","q3","r3","s3","t3","u3","v3","z3" }
            }; // Matrice per il riferimento del codice dell' immagine.
            
            source = "img/" + matLettere[num, lettera] + ".jpg"; // Creazione della source.
            

            // Nuova Immagine.
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit(); // Inizio inizializzazione del BitmapImage.
            bi3.UriSource = new Uri(source, UriKind.Relative);
            bi3.EndInit(); // Fine Inizializzazione.
            img.Stretch = Stretch.Fill;
            img.Source = bi3; // Passaggio del Source all'immagine.
            lblNome.Content = nomi[num, lettera]; // Passaggio del nome.
            
        }

        private void ClickA(object sender, RoutedEventArgs e)
        {
            lettera = 0; // Assegnazione alla variabile il valore della riga per la matrice. 
            matrice(); // Visione dell'immagine.
        }

        private void ClickB(object sender, RoutedEventArgs e)
        {
            lettera = 1;
            matrice();
        }

        private void ClickC(object sender, RoutedEventArgs e)
        {
            lettera = 2;
            matrice();
        }

        private void ClickD(object sender, RoutedEventArgs e)
        {

            lettera = 3;
            matrice();
        }

        private void ClickE(object sender, RoutedEventArgs e)
        {

            lettera = 4;
            matrice();
        }

        private void ClickF(object sender, RoutedEventArgs e)
        {

            lettera = 5;
            matrice();
        }

        private void ClickG(object sender, RoutedEventArgs e)
        {
 
            lettera = 6;
            matrice();
        }

        private void ClickH(object sender, RoutedEventArgs e)
        {

            lettera = 7;
            matrice();
        }

        private void ClickI(object sender, RoutedEventArgs e)
        {

            lettera = 8;
            matrice();
        }

        private void ClickL(object sender, RoutedEventArgs e)
        {

            lettera = 9;
            matrice();
        }

        private void ClickM(object sender, RoutedEventArgs e)
        {

            lettera = 10;
            matrice();
        }

        private void ClickN(object sender, RoutedEventArgs e)
        {

            lettera = 11;
            matrice();
        }

        private void ClickO(object sender, RoutedEventArgs e)
        {
            lettera = 12;
            matrice();
        }

        private void ClickP(object sender, RoutedEventArgs e)
        {
            lettera = 13;
            matrice();
        }

        private void ClickQ(object sender, RoutedEventArgs e)
        {
            lettera = 14;
            matrice();
        }

        private void ClickR(object sender, RoutedEventArgs e)
        {
            lettera = 15;
            matrice();
        }

        private void ClickS(object sender, RoutedEventArgs e)
        {

            lettera = 16;
            matrice();
        }

        private void ClickT(object sender, RoutedEventArgs e)
        {
            lettera = 17;
            matrice();
        }

        private void ClickU(object sender, RoutedEventArgs e)
        {

            lettera = 18;
            matrice();
        }

        private void ClickV(object sender, RoutedEventArgs e)
        {
            lettera = 19;
            matrice();
        }

        private void ClickZ(object sender, RoutedEventArgs e)
        {
            lettera = 20;
            matrice();
        }
    }
}
