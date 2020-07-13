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

namespace SchnellerKaputtWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Kundenliste erstellen
        List<kunde> Kundenliste = new List<kunde>();
        
        public MainWindow()
        {
            InitializeComponent();

            //Kundendaten aus XML Laden
            LadenSpeichern ls = new LadenSpeichern();
            Kundenliste = ls.KundenLaden();




#if DEBUG

            //Testdaten Laden wenn Kundenliste leer und debugger angebunden 
            if (Kundenliste.Count < 1)
            {
                testdatenLaden();

            }

#endif

            //Datengrid an Listen binden
            DG_Kunden.ItemsSource = Kundenliste;



        }


        void testdatenLaden()
        {
            Kundenliste.Add(new kunde("Hans", "Wurst", "Beispielstr.", "66a", "90402", "Nürnberg", "16.12.1985", "0911-6548945", "hans@wurst.bsp"));
            Kundenliste.Add(new kunde("Heinz", "Ketchup", "Dummyweg", "63t", "90403", "Nürnberg", "16.12.1915", "0911-643536", "heinz@wurst.bsp"));
            Kundenliste.Add(new kunde("Anna", "Conda", "Condastr.", "128a", "90404", "Nürnberg", "16.05.1975", "0911-8796723", "anna@conda.nbg"));
            Kundenliste.Add(new kunde("Max", "Mustermann", "Musterstr.", "128a", "90404", "Nürnberg", new adresse("Musterstr.", "23", "91124", "Fürth"), "12.05.1995", "0911-8796723", "anna@muster.nbg"));
            Kundenliste.Add(new kunde("Maxi", "Muster", "Musterstr.", "128a", "90404", "Nürnberg", new adresse("bspstr.", "13", "56784", "Köln"), "12.05.1995", "0911-8796723", "maxi@muster.nbg"));
            Kundenliste.Add(new kunde("Maxi", "Muster",new adresse( "Musterstr.", "128a", "90404", "Nürnberg"), new adresse("bspstr.", "13", "56784", "Köln"), "12.05.1995", "0911-8796723", "maxi@muster.nbg"));
            
            Kundenliste[0].Termine.Add(new termin(new DateTime(2020, 02, 13, 11, 00, 00), new DateTime(2020, 02, 13, 13, 00, 00), "Guter Kunde", Grund.Service));
            Kundenliste[0].Termine.Add(new termin(new DateTime(2020, 02, 14, 13, 00, 00), new DateTime(2020, 02, 15, 13, 00, 00), "Guter Kunde", Grund.Service));
            Kundenliste[1].Termine.Add(new termin(new DateTime(2020, 02, 14, 11, 00, 00), new DateTime(2020, 02, 13, 13, 00, 00), "Schlechter Kunde", Grund.Service));
            Kundenliste[1].Termine.Add(new termin(new DateTime(2020, 02, 17, 11, 00, 00), new DateTime(2020, 02, 13, 13, 00, 00), "Schlechter Kunde", Grund.Service));


        }

        private void BT_KD_Aendern_Click(object sender, RoutedEventArgs e)
        {
            //meldung wenn kein Kunde gewählt
            if (DG_Kunden.SelectedIndex < 0)
            {
                MessageBox.Show("Kein Kunde gewählt, Maske zur neuanlage wird geöffnet.");
            }

            //Fenster erstellen
            anlegen_aendern aaf = new anlegen_aendern(Kundenliste, DG_Kunden.SelectedIndex);
            //Fenster öffnen
            aaf.ShowDialog();

            //Datengrid Aktualisieren
            DG_Kunden.ItemsSource = null;
            DG_Kunden.ItemsSource = Kundenliste;

        }

        private void BT_KD_Anlegen_Click(object sender, RoutedEventArgs e)
        {
            //Fenster erstellen
            anlegen_aendern aaf = new anlegen_aendern(index: -1, Kundenliste: Kundenliste);
            //Fenster öffnen
            aaf.ShowDialog();

            //Datengrid Aktualisieren
            DG_Kunden.ItemsSource = null;
            DG_Kunden.ItemsSource = Kundenliste;
        }

        private void BT_KD_Loeschen_Click(object sender, RoutedEventArgs e)
        {
            if (DG_Kunden.SelectedIndex >= 0)
            {
                Kundenliste.RemoveAt(DG_Kunden.SelectedIndex);


            }
            else
            {
                MessageBox.Show("Bitte zuerst Kunde Auswählen");
            }
            //Datengrid Aktualisieren
            DG_Kunden.ItemsSource = null;
            DG_Kunden.ItemsSource = Kundenliste;

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LadenSpeichern ls = new LadenSpeichern();
            ls.KundenSpeichern(Kundenliste);
        }

        private void BT_Terminanzeigen_Click(object sender, RoutedEventArgs e)
        {
            DG_Termine.ItemsSource = null;
            DG_Termine.ItemsSource = Kundenliste[DG_Kunden.SelectedIndex].Termine;
        }

        private void BT_Alle_Termine_Click(object sender, RoutedEventArgs e)
        {
            //Liste aller Termine 
            List<kundentermine> alleTermine = new List<kundentermine>();

            foreach (var aktuellerKunde in Kundenliste)
            {
                if (aktuellerKunde.Termine.Count != 0)
                {
                    foreach (var aktuellerTermin in aktuellerKunde.Termine)
                    {
                        alleTermine.Add(new kundentermine(aktuellerTermin, aktuellerKunde.Name));
                    }
                }
            }

            DG_Termine.ItemsSource = null;
            DG_Termine.ItemsSource = alleTermine;

        }

        private void BT_Heutige_Termine_Click(object sender, RoutedEventArgs e)
        {
            //Liste aller Termine 
            List<kundentermine> alleTermine = new List<kundentermine>();

            foreach (var aktuellerKunde in Kundenliste)
            {
                if (aktuellerKunde.Termine.Count != 0)
                {
                    foreach (var aktuellerTermin in aktuellerKunde.Termine)
                    {
                        if (aktuellerTermin.Start.Date == DateTime.Now.Date)
                        {
                        alleTermine.Add(new kundentermine(aktuellerTermin, aktuellerKunde.Name));
                        }
                    }
                }
            }

            DG_Termine.ItemsSource = null;
            DG_Termine.ItemsSource = alleTermine;

        }

        private void BT_Neuer_Termin_Click(object sender, RoutedEventArgs e)
        {
            //Instanzieren mit Kunden (2. Konstruktor)
            termine_anlegen_aendern taaf = new termine_anlegen_aendern(Kundenliste[DG_Kunden.SelectedIndex]);
            taaf.ShowDialog();
            
        }

        private void BT_Termin_bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            termine_anlegen_aendern taaf;
            if (DG_Termine.Columns.Count > 3)
            {
                //Instanzieren mit termin  (1. Konstruktor)
                taaf = new termine_anlegen_aendern((termin)DG_Termine.SelectedItem);
            }
            else
            {
                //Instanzieren mit termin  (1. Konstruktor)
                taaf = new termine_anlegen_aendern(((kundentermine)DG_Termine.SelectedItem).Kundentermin);
            }
            taaf.ShowDialog();
        }

  

        private void DG_Termine_Selected(object sender, SelectedCellsChangedEventArgs e)
        {

            BT_Termin_bearbeiten.Visibility = Visibility.Visible;
        }

        private void DG_Kunden_Selected(object sender, SelectedCellsChangedEventArgs e)
        {
            BT_Terminanzeigen.Visibility = Visibility.Visible;
            BT_Neuer_Termin.Visibility = Visibility.Visible;

        }
    }
}
