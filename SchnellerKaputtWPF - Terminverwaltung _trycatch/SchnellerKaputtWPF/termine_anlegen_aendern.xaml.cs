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
using System.Windows.Shapes;

namespace SchnellerKaputtWPF
{
    /// <summary>
    /// Interaktionslogik für termine_anlegen_aendern.xaml
    /// </summary>
    public partial class termine_anlegen_aendern : Window
    {
        termin Termin;
        kunde aktuellerKunde;

        //Constructor mit Termin parameter zum ändern eines Termins
        public termine_anlegen_aendern(termin Termin)
        {
            InitializeComponent();
            this.Termin = Termin;

            //Combobox eine"Datenbasis" zuteilen
            CB_grund.ItemsSource = Enum.GetValues(typeof(Grund));

            //Fenster anpassen für ändern
            this.Title = "Termin Ändern";
            BT_erstellen.Content = "Ändern";

            //Felder im Fenster mit aktuellen Termin füllen
            DP_beginn.SelectedDate = Termin.Start;
            TB_Beginn_std.Text = Termin.Start.Hour.ToString();
            TB_Beginn_min.Text = Termin.Start.Minute.ToString();

            DP_ende.SelectedDate = Termin.Ende;
            TB_Ende_std.Text = Termin.Ende.Hour.ToString();
            TB_ende_min.Text = Termin.Ende.Minute.ToString();

            CB_grund.SelectedItem = Termin.Termingrund;
            CB_bestaetigt.IsChecked = Termin.Erledigt;
            TB_bemerkung.Text = Termin.Bemerkung;

        }
        //Consturctor mit Kunde um neuen Termin im Kunden zu erstellen
        public termine_anlegen_aendern(kunde AktuellerKunde)
        {
            aktuellerKunde = AktuellerKunde;
            InitializeComponent();

            //erledigt feld verstecken da neuer Termin
            CB_bestaetigt.Visibility = Visibility.Hidden;

            //Combobox eine"Datenbasis" zuteilen
            CB_grund.ItemsSource = Enum.GetValues(typeof(Grund));
        }

        private void BT_erstellen_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                DateTime startdatum = DP_beginn.SelectedDate.GetValueOrDefault();
                DateTime start = new DateTime(startdatum.Year, startdatum.Month, startdatum.Day, Convert.ToInt32(TB_Beginn_std.Text), Convert.ToInt32(TB_Beginn_min.Text), 0);

                DateTime enddatum = DP_ende.SelectedDate.GetValueOrDefault();
                DateTime ende = new DateTime(enddatum.Year, enddatum.Month, enddatum.Day, Convert.ToInt32(TB_Ende_std.Text), Convert.ToInt32(TB_ende_min.Text), 0);

                if (DP_beginn.SelectedDate.GetValueOrDefault() > DP_ende.SelectedDate.GetValueOrDefault())
                {
                    MessageBox.Show("Ende liegt vor beginn!");
                }
                else
                {

                    if (BT_erstellen.Content.ToString() == "Erstellen")
                    {//Neuer Termin

                        aktuellerKunde.Termine.Add(new termin(start, ende, TB_bemerkung.Text, (Grund)CB_grund.SelectedItem));
                    }
                    else
                    {
                        Termin.Start = start;
                        Termin.Ende = ende;
                        Termin.Erledigt = (bool)CB_bestaetigt.IsChecked;
                        Termin.Termingrund = (Grund)CB_grund.SelectedItem;
                        Termin.Bemerkung = TB_bemerkung.Text;
                    }

                }
            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("Alle felder müssen ausgefüllt werden!");
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Bitte Grund auswählen!");
            }
            catch(FormatException)
            {
                MessageBox.Show("Falsche werte eingegeben, bitte Uhrzeit als Ganzzahl!");
            }
            //Wenn Uhrzeit größer 24 std oder größer 60 min 
            catch(ArgumentOutOfRangeException)
            {

                MessageBox.Show("Falsches Datumsformat.");
            }

            this.Close();
        }
    }
}


