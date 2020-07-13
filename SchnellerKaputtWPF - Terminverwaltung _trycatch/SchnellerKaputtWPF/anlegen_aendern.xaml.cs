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
    /// Interaktionslogik für anlegen_aendern.xaml
    /// </summary>
    public partial class anlegen_aendern : Window
    {
        List<kunde> Kundenliste;
        int index;
        public anlegen_aendern(List<kunde> Kundenliste, int index)
        {
            InitializeComponent();
            this.Kundenliste = Kundenliste;
            this.index = index;
            //Prüfen ob anlegen oder ändern
            if (index == -1)
            {
                //anlegen
            }
            else
            {
                //ändern
                //Fenster für ändern anpassen
                this.Title = "Kundendaten ändern";
                BT_speichern.Content = "Ändern";
                //Felder mit Kundendaten füllen
                TB_Nname.Text = Kundenliste[index].nname;
                TB_Vname.Text = Kundenliste[index].vname;
                TB_Strasse.Text = Kundenliste[index].anschrift.Strasse;
                TB_Hausnummer.Text = Kundenliste[index].anschrift.Hausnummer;
                TB_PLZ.Text = Kundenliste[index].anschrift.Plz;
                TB_Ort.Text = Kundenliste[index].anschrift.Ort;
                TB_Telefon.Text = Kundenliste[index].telefonnummer;
                TB_mail.Text = Kundenliste[index].email;
                TB_Geburtsdatum.Text = Kundenliste[index].geburtsdatum.ToShortDateString();

                if (Kundenliste[index].anschrift.Strasse != Kundenliste[index].lieferanschrift.Strasse)
                {
                    CB_Lieferanschrift.IsChecked = true;
                    TB_Strasse_la.Text = Kundenliste[index].lieferanschrift.Strasse;
                    TB_Hausnummer_la.Text = Kundenliste[index].lieferanschrift.Hausnummer;
                    TB_PLZ_la.Text = Kundenliste[index].lieferanschrift.Plz;
                    TB_Ort_la.Text = Kundenliste[index].lieferanschrift.Ort;
                }





            }


        }

        private void BT_speichern_Click(object sender, RoutedEventArgs e)
        {
            bool close = true;
            try
            {


                if (index == -1)
                {
                    //Kunde Neu Anlegen

                    //Prüfung Lieferanschrift = Anschrift
                    if (CB_Lieferanschrift.IsChecked == true)
                    {
                        //wenn abfrage true dann mit Lieferanschrift
                        adresse Lieferanschrift = new adresse(TB_Strasse_la.Text, TB_Hausnummer_la.Text, TB_PLZ_la.Text, TB_Ort_la.Text);
                        Kundenliste.Add(new kunde(TB_Vname.Text, TB_Nname.Text, TB_Strasse.Text, TB_Hausnummer.Text, TB_PLZ.Text, TB_Ort.Text, Lieferanschrift, TB_Geburtsdatum.Text, TB_Telefon.Text, TB_mail.Text));
                    }
                    else
                    {
                        //Wenn ohne Lieferanschrift
                        Kundenliste.Add(new kunde(TB_Vname.Text, TB_Nname.Text, TB_Strasse.Text, TB_Hausnummer.Text, TB_PLZ.Text, TB_Ort.Text, TB_Geburtsdatum.Text, TB_Telefon.Text, TB_mail.Text));
                    }
                }
                else
                {
                    //Kundendaten ändern
                    Kundenliste[index].nname = TB_Nname.Text;
                    Kundenliste[index].vname = TB_Vname.Text;
                    Kundenliste[index].email = TB_mail.Text;
                    Kundenliste[index].telefonnummer = TB_Telefon.Text;
                    DateTime tempDat = Kundenliste[index].geburtsdatum;
                    if (DateTime.TryParse(TB_Geburtsdatum.Text, out Kundenliste[index].geburtsdatum))
                    { }
                    else
                    {
                        MessageBox.Show("Falsches Datumsformat.");
                        Kundenliste[index].geburtsdatum = tempDat;
                        close = false;
                    }

                    Kundenliste[index].anschrift.Umzug(TB_Strasse.Text, TB_Hausnummer.Text, TB_PLZ.Text, TB_Ort.Text);

                    if (CB_Lieferanschrift.IsChecked == true)
                    {
                        //falls abweichende lieferanschrift 
                        Kundenliste[index].lieferanschrift.Umzug(TB_Strasse_la.Text, TB_Hausnummer_la.Text, TB_PLZ_la.Text, TB_Ort_la.Text);

                    }
                }
                if (close)
                {
                    this.Close();

                }

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Alle felder müssen ausgefüllt werden!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Bitte Grund auswählen!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Falsches Datumsformat.");
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Falsches Datumsformat.");
            }
        }
    }
}
