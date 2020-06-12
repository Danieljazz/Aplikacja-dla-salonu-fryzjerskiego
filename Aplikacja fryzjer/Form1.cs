using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Aplikacja_fryzjer
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();  //zmienna globalna prywatna dla klasy Form 1
        public Form1()
        {
            InitializeComponent();

            try //laczymy z baza danych, lapiemy wyjątek
            {
               // w celu poprawnego działania programu musimy ustawic Data Source na sciezke naszego pliku Access
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Daniel\Documents\Visual Studio 2017\Backup Files\Aplikacja fryzjer\fryzjer.accdb; Persist Security Info=False;";
                connection.Open();
                label1.Text = "Połączono"; //status połączenia z bazą danych 
                connection.Close();
            }
            catch (Exception ex) //gdy sie nie polaczy
            {
                MessageBox.Show("Error" + ex); 
            }


            try
            {
                connection.Open(); 
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection; 
                command.CommandText = "select Data from Tabela1";

                OleDbDataReader reader = command.ExecuteReader();
                List<DateTime> listBoldedDates = new List<DateTime>();
                while (reader.Read())
                {
                    string data = reader.GetValue(0).ToString();
                    DateTime dan = Convert.ToDateTime(data);
                    listBoldedDates.Add(dan);
                    // monthCalendar1.AddBoldedDate(dan);
                }
                
                monthCalendar1.BoldedDates = listBoldedDates.ToArray();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {/* 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.ShowUpDown = true;
            DateTime myDate = dateTimePicker2.Value.Date +
                   dateTimePicker2.Value.TimeOfDay;
            //dateTimePicker2.Value = myDate.Date + myDate.TimeOfDay; //datetimepicker.value zwraca date i godzine możemy dodać do accessa
            //dateTimePicker2.Value = myDate.TimeOfDay;

            // lbl_data.Text = myDate.Date.ToString("dd/MM/yyyy");
            
            lbl_godz.Text = myDate.ToString("HH:mm"); */
          
        }
       

        private void dateTimePicker2_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open(); //otwiera polaczenie z baza danych 
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;  
                command.CommandText = "insert into Tabela1 (Data, Godzina, Imie, Nazwisko, Tel) values('"+ lbl_data.Text + "','" + lbl_godz.Text + "','" + txt_imie.Text + "','" + txt_nazwisko.Text + "','" + txt_tel.Text + "') "; //wyciagamy i tworzymy query, wpisujemy nazwę tabeli  
                                                            // nazwy kolumn w tabeli                       //nazwy pol skad pobieramy dane                       
                
                //.ExecuteReader odczytujemy wartosci/ pobieramy  
                command.ExecuteNonQuery();//.ExecuteNonQuery--updatuje zapisuje i usuwa z bazy danych jesli uzywamy ''to string jesli "" to liczba 

                MessageBox.Show("Zapisano");   
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            monthCalendar1.UpdateBoldedDates();
            refresh();

        }

        private void txt_imie_TextChanged(object sender, EventArgs e)
        {
            txt_imie.Text = "";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open(); //otwiera polaczenie z baza danych 
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;  
                string query = "update Tabela1 set Data='" + lbl_data.Text + "', Godzina='" + lbl_godz.Text + "', Imie='" + txt_imie.Text + "', Nazwisko='" + txt_nazwisko.Text + "', Tel='" + txt_tel.Text + "' where Identyfikator="+txt_id.Text+"";
                //update "nazwa tabeli" set-zmiana wartosci potem nazwa z tabeli i pola z wartosciami where podajemy id w ktorym zmieniamy wartosci dajemy "" dla id bo to numerki
                command.CommandText = query;             
                command.ExecuteNonQuery();//.ExecuteNonQuery--updatuje zapisuje i usuwa z bazy danych jesli uzywamy ''to string jesli "" to liczba 

                MessageBox.Show("Edycja przebiegła pomyślnie");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            monthCalendar1.UpdateBoldedDates();
            refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'fryzjerDataSet.Tabela1' . Możesz go przenieść lub usunąć.
            this.tabela1TableAdapter.Fill(this.fryzjerDataSet.Tabela1);
            lbl_data.Text = DateTime.Now.ToShortDateString();

            //godzina co 30 min
            var item = DateTime.Today.AddHours(8); // 8:00
            while (item <= DateTime.Today.AddHours(18)) // 18:00
            {
                comboBox1.Items.Add(item.TimeOfDay.ToString(@"hh\:mm"));
                item = item.AddMinutes(30);
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbl_data.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            Application.EnableVisualStyles();
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
           // refresh();
   
           
        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_znjd_Click(object sender, EventArgs e)
        {
            
                connection.Open(); //otwiera polaczenie z baza danych 
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection; //?? 
                command.CommandText = "select * from Tabela1 where Data= '"+lbl_data.Text+"' and Godzina = '"+lbl_godz.Text+"' "; //*zaimast identyfikator wybiera wszyskie kolumny, w access data nie moze byc jako data
             
                OleDbDataReader reader = command.ExecuteReader();//.ExecuteReader--tylko do odczytu nie możemy w bazie danych usatwic parametru data na typ data/godzina bo nie będzie działać 
            while (reader.Read())
            {
                txt_id.Text = reader.GetValue(0).ToString(); //0 id wizyty
                lbl_godz.Text = reader.GetValue(2).ToString();//2 godzina 
                txt_imie.Text = reader.GetValue(3).ToString(); 
                txt_nazwisko.Text = reader.GetValue(4).ToString(); 
                txt_tel.Text = reader.GetValue(5).ToString();
                //GetValue(1) - data 
            }

            connection.Close();
        }

        private void btn_usun_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();  
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection; //?? 
                string query = "delete from Tabela1 where Identyfikator="+txt_id.Text+"";
                //delete z nazwa tabeli z kolumny ktorej chemy usunac 
                command.CommandText = query;             
                command.ExecuteNonQuery(); 
                MessageBox.Show("Usunięto wizytę :(");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            monthCalendar1.UpdateBoldedDates();
            refresh();
            
        }

        private void btn_wizyty_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection; 
                string query = "select * from Tabela1 where Data= '" + lbl_data.Text + "'";
                command.CommandText = query;

                OleDbDataAdapter data = new OleDbDataAdapter(command);
                DataTable datatable = new DataTable();
                data.Fill(datatable);
                dataGridView1.DataSource = datatable; // w tych 4 linijkach laczymy baze danych z data grid view
              dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);  //sortowanie gridView
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.dataGridView1.Columns["Godzina"].SortMode=DataGridViewColumnSortMode.Automatic;
        }

        private void btn_szuk_nazw_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Tabela1 where Nazwisko= '" + txt_nazwisko.Text + "'";
                command.CommandText = query;

                OleDbDataAdapter data = new OleDbDataAdapter(command);
                DataTable datatable = new DataTable();
                data.Fill(datatable);
                dataGridView1.DataSource = datatable;
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_godz.Text = comboBox1.Text;
        }





        public void refresh()
        {
            txt_id.Text = "";
            txt_imie.Text = "";
            txt_nazwisko.Text = "";
            txt_tel.Text = "";
            try
            {
                connection.Open();  
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection; 
                command.CommandText = "select Data from Tabela1";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    string data = reader.GetValue(0).ToString();
                    DateTime dan = Convert.ToDateTime(data);
                    monthCalendar1.RemoveBoldedDate(dan);
                   
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                connection.Open();  
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;  
                command.CommandText = "select Data from Tabela1";


                List<DateTime> listBoldedDates = new List<DateTime>();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string data = reader.GetValue(0).ToString();
                    DateTime dan = Convert.ToDateTime(data);
                    listBoldedDates.Add(dan);
                    
                }
                monthCalendar1.BoldedDates = listBoldedDates.ToArray();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_ndch_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Tabela1 where Data>='"+DateTime.Today+"'";
                command.CommandText = query;

                OleDbDataAdapter data = new OleDbDataAdapter(command);
                DataTable datatable = new DataTable();
                data.Fill(datatable);
                dataGridView1.DataSource = datatable; 
                
                dataGridView1.Sort(dataGridView1.Columns["Data"], ListSortDirection.Ascending);
               
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }


        }

        private void lbl_data_Click(object sender, EventArgs e)
        {

        }
    }
}
