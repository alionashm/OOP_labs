using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxAuto.SelectedIndex = 0;
        }
        List<Vehicle> Autos = new List<Vehicle>();

        private void dataGridUpd()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Выберите ТС.");
            dataGridView1.Rows.Clear();
            ClearFields();
            for (int i = 0; i < Autos.Count; i++)
                dataGridView1.Rows.Add(Autos[i].Brand, Autos[i].Model, Autos[i].Year, $"{Autos[i].Engine.NumOfCylind} цилиндров {Autos[i].Engine.Power}л.с.");
        }
        private void ClearFields()
        {
            textBoxBrand.Clear();
            textBoxModel.Clear();
            textBoxPower.Clear();
            textBoxNumofCyl.Clear();
            textBoxYear.Clear();
            comboBoxAuto.SelectedIndex = 0;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            int CarCount = 0, TruckCount = 0, BusCount = 0, TaxisCount = 0;
            double profit = 0;
            listBox1.Items.Clear();
            for (int i = 1; i <= count; i++)
            {
                if (Autos[i - 1] is Car)
                {
                    CarCount++;
                }
                else if (Autos[i - 1] is Truck)
                {
                    TruckCount++;
                }
                else if (Autos[i - 1] is Taxis)
                {
                    Taxis vehTaxis = Autos[i - 1] as Taxis;
                    TaxisCount++;
                    profit = profit + vehTaxis.Profit(vehTaxis.NumOfRoutes);
                }

                else if (Autos[i - 1] is Bus)
                {
                    BusCount++;
                }
            }
            listBox1.Items.Add($"Всего в автопарке: { count } ТС");
            listBox1.Items.Add($"Легковых автомобилей: { CarCount }");
            listBox1.Items.Add($"Грузовых автомобилей: { TruckCount }");
            listBox1.Items.Add($"Автобусов: { BusCount }");
            listBox1.Items.Add($"Маршрутных такси: { TaxisCount }");
            listBox1.Items.Add($"Выгода от маршруток составляет { profit } крышек");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Списать ТС " + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + " " + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value + "?", "Списывание ТС", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Autos.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                    MessageBox.Show("ТС списано из автопарка!");
                }
                dataGridUpd();
            }
            catch
            {
                MessageBox.Show("ТС не выбрано!");
            }
        }

        private void FillFields()
        {
            textBoxBrand.Text = Autos[dataGridView1.SelectedCells[0].RowIndex].Brand;
            textBoxModel.Text = Autos[dataGridView1.SelectedCells[0].RowIndex].Model;
            textBoxPower.Text = Autos[dataGridView1.SelectedCells[0].RowIndex].Engine.Power.ToString();
            textBoxNumofCyl.Text = Autos[dataGridView1.SelectedCells[0].RowIndex].Engine.NumOfCylind.ToString();
            textBoxYear.Text = Autos[dataGridView1.SelectedCells[0].RowIndex].Year.ToString();
            comboBoxAuto.SelectedIndex = 0;
            if (Autos[dataGridView1.SelectedCells[0].RowIndex] is Car)
            {
                comboBoxAuto.SelectedIndex = 1;
                Car veh = Autos[dataGridView1.SelectedCells[0].RowIndex] as Car;
                textBoxSeats.Text = veh.NumOfSeats.ToString();
                textBoxType.Text = veh.Type;
                textBoxCategory.Text = veh.Category;
            }
            else if (Autos[dataGridView1.SelectedCells[0].RowIndex] is Truck)
            {
                comboBoxAuto.SelectedIndex = 2;
                Truck veh = Autos[dataGridView1.SelectedCells[0].RowIndex] as Truck;
                textBoxLoad.Text = veh.LoadCapacity.ToString();
                textBoxAxles.Text = veh.NumOfAxles.ToString();
            }
            else if (Autos[dataGridView1.SelectedCells[0].RowIndex] is Taxis)
            {
                comboBoxAuto.SelectedIndex = 4;
                Taxis vehTaxis = Autos[dataGridView1.SelectedCells[0].RowIndex] as Taxis;
                textBoxRoutes.Text = vehTaxis.NumOfRoutes.ToString();
                textBoxLen.Text = vehTaxis.Length.ToString();
                textBoxApp.Text = vehTaxis.Appointment;
            }
            else if (Autos[dataGridView1.SelectedCells[0].RowIndex] is Bus)
            {
                comboBoxAuto.SelectedIndex = 3;
                Bus veh = Autos[dataGridView1.SelectedCells[0].RowIndex] as Bus;
                textBoxLen.Text = veh.Length.ToString();
                textBoxApp.Text = veh.Appointment;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInputVal())
                {
                    Autos[dataGridView1.SelectedCells[0].RowIndex].Brand = textBoxBrand.Text;
                    Autos[dataGridView1.SelectedCells[0].RowIndex].Model = textBoxModel.Text;
                    Autos[dataGridView1.SelectedCells[0].RowIndex].Year = Convert.ToInt32(textBoxYear.Text);
                    Autos[dataGridView1.SelectedCells[0].RowIndex].Engine.NumOfCylind = Convert.ToInt32(textBoxNumofCyl.Text);
                    Autos[dataGridView1.SelectedCells[0].RowIndex].Engine.Power = Convert.ToInt32(textBoxPower.Text);
                    comboBoxAuto.SelectedIndex = 0;
                    if (Autos[dataGridView1.SelectedCells[0].RowIndex] is Car)
                    {
                        comboBoxAuto.SelectedIndex = 1;
                        Car veh = Autos[dataGridView1.SelectedCells[0].RowIndex] as Car;
                        veh.NumOfSeats = Convert.ToInt32(textBoxSeats.Text);
                        veh.Type = textBoxType.Text;
                        veh.Category = textBoxCategory.Text;
                        Autos[dataGridView1.SelectedCells[0].RowIndex] = veh;
                    }
                    else if (Autos[dataGridView1.SelectedCells[0].RowIndex] is Truck)
                    {
                        comboBoxAuto.SelectedIndex = 2;
                        Truck veh = Autos[dataGridView1.SelectedCells[0].RowIndex] as Truck;
                        veh.LoadCapacity = Convert.ToInt32(textBoxLoad.Text);
                        veh.NumOfAxles = Convert.ToInt32(textBoxAxles.Text);
                        Autos[dataGridView1.SelectedCells[0].RowIndex] = veh;
                    }
                    else if (Autos[dataGridView1.SelectedCells[0].RowIndex] is Taxis)
                    {
                        comboBoxAuto.SelectedIndex = 4;
                        Taxis vehTaxis = Autos[dataGridView1.SelectedCells[0].RowIndex] as Taxis;
                        vehTaxis.NumOfRoutes = Convert.ToInt32(textBoxRoutes.Text);
                        vehTaxis.Length = Convert.ToInt32(textBoxLen.Text);
                        vehTaxis.Appointment = textBoxApp.Text;
                        Autos[dataGridView1.SelectedCells[0].RowIndex] = vehTaxis;
                    }
                    else if (Autos[dataGridView1.SelectedCells[0].RowIndex] is Bus)
                    {
                        comboBoxAuto.SelectedIndex = 3;
                        Bus veh = Autos[dataGridView1.SelectedCells[0].RowIndex] as Bus;
                        veh.Length = Convert.ToInt32(textBoxLen.Text);
                        veh.Appointment = textBoxApp.Text;
                        Autos[dataGridView1.SelectedCells[0].RowIndex] = veh;
                    }
                    dataGridUpd();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!");
                }
            }
            catch
            {
                MessageBox.Show("ТС не выбрано!");
            }
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            listBox1.Items.Clear();
            FillFields();
            try
            {
                listBox1.Items.Add($"{ Autos[dataGridView1.SelectedCells[0].RowIndex].Brand} { Autos[dataGridView1.SelectedCells[0].RowIndex].Model}");
                listBox1.Items.Add($"Год выпуска: { Autos[dataGridView1.SelectedCells[0].RowIndex].Year}");


                if (Autos[dataGridView1.SelectedCells[0].RowIndex] is Car)
                {
                    Car veh = Autos[dataGridView1.SelectedCells[0].RowIndex] as Car;
                    listBox1.Items.Add("Вид ТС: легковушка");
                    listBox1.Items.Add($"Кол-во мест: { veh.NumOfSeats}");
                    listBox1.Items.Add($"Тип кузова: { veh.Type}");
                    listBox1.Items.Add($"Категория: { veh.Category}");
                }
                else if (Autos[dataGridView1.SelectedCells[0].RowIndex] is Truck)
                {
                    Truck veh = Autos[dataGridView1.SelectedCells[0].RowIndex] as Truck;
                    listBox1.Items.Add("Вид ТС: грузовое авто");
                    listBox1.Items.Add($"Грузоподъемность: { veh.LoadCapacity}кг");
                    listBox1.Items.Add($"Кол-во осей: { veh.NumOfAxles}");
                }
                else if (Autos[dataGridView1.SelectedCells[0].RowIndex] is Taxis)
                {
                    Taxis vehTaxis = Autos[dataGridView1.SelectedCells[0].RowIndex] as Taxis;
                    listBox1.Items.Add("Вид ТС: маршрутное такси");
                    listBox1.Items.Add($"Вместимость: { vehTaxis.Length} пассажиромест");
                    listBox1.Items.Add($"Назначение: { vehTaxis.Appointment}");
                    listBox1.Items.Add($"Длина маршрута: { vehTaxis.NumOfRoutes} км");
                    listBox1.Items.Add($"Выгода да выезд: { vehTaxis.Profit(vehTaxis.NumOfRoutes) } крышек");
                }

                else if (Autos[dataGridView1.SelectedCells[0].RowIndex] is Bus)
                {
                    Bus veh = Autos[dataGridView1.SelectedCells[0].RowIndex] as Bus;
                    listBox1.Items.Add("Вид ТС: автобус");
                    listBox1.Items.Add($"Вместимость: { veh.Length} пассажиромест");
                    listBox1.Items.Add($"Назначение: { veh.Appointment}");
                }
                else
                {
                    listBox1.Items.Add("Вид ТС: автомобиль");
                }
            }
            catch
            {
                MessageBox.Show("Выберите ТС!");
            }
        }

        private bool checkInputVal()
        {
            if (textBoxBrand.Text == "" || textBoxModel.Text == "" || textBoxYear.Text == "" || textBoxNumofCyl.Text == "" || textBoxPower.Text == "")
                return false;
            else
                return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (checkInputVal())
            {
                Vehicle trans;
                string autoCh = comboBoxAuto.Text.ToString();
                string brand = textBoxBrand.Text;
                string model = textBoxModel.Text;
                int year = Convert.ToInt32(textBoxYear.Text);
                Engine engine = new Engine(Convert.ToInt32(textBoxNumofCyl.Text), Convert.ToInt32(textBoxPower.Text));

                if (autoCh.Equals("Легковой автомобиль"))
                {
                    int seat = Convert.ToInt32(textBoxSeats.Text);
                    string type = textBoxType.Text;
                    string cat = textBoxCategory.Text;
                    trans = new Car(brand, model, year, engine, seat, type, cat);
                }
                else if (autoCh.Equals("Автомобиль"))
                    trans = new Vehicle(brand, model, year, engine);
                else if (autoCh.Equals("Автобус"))
                {
                    int length = Convert.ToInt32(textBoxLen.Text);
                    string app = textBoxApp.Text;
                    trans = new Bus(brand, model, year, engine, length, app);
                }
                else if (autoCh.Equals("Грузовой автомобиль"))
                {
                    int capacity = Convert.ToInt32(textBoxLoad.Text);
                    int axles = Convert.ToInt32(textBoxAxles.Text);
                    trans = new Truck(brand, model, year, engine, capacity, axles);
                }
                else if (autoCh.Equals("Маршрутное такси"))
                {
                    int length = Convert.ToInt32(textBoxLen.Text);
                    string app = textBoxApp.Text;
                    int route = Convert.ToInt32(textBoxRoutes.Text);
                    trans = new Taxis(brand, model, year, engine, length, app, route);
                }
                else
                    throw new Exception(autoCh + " отсутствует в автопарке!");
                Autos.Add(trans);
                dataGridUpd();

            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }


        }

        private void comboBoxProfession_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Visible = false;
            textBoxSeats.Visible = false;
            label8.Visible = false;
            textBoxType.Visible = false;
            label7.Visible = false;
            textBoxCategory.Visible = false;
            label14.Visible = false;
            textBoxLen.Visible = false;
            label13.Visible = false;
            textBoxApp.Visible = false;
            label11.Visible = false;
            textBoxRoutes.Visible = false;
            label10.Visible = false;
            textBoxLoad.Visible = false;
            label6.Visible = false;
            textBoxAxles.Visible = false;
            if (comboBoxAuto.SelectedIndex == 1)
            {
                label9.Visible = true;
                textBoxSeats.Visible = true;
                label8.Visible = true;
                textBoxType.Visible = true;
                label7.Visible = true;
                textBoxCategory.Visible = true;
            }
            else if (comboBoxAuto.SelectedIndex == 2)
            {
                label10.Visible = true;
                textBoxLoad.Visible = true;
                label6.Visible = true;
                textBoxAxles.Visible = true;
            }
            else if (comboBoxAuto.SelectedIndex == 3)
            {
                label14.Visible = true;
                textBoxLen.Visible = true;
                label13.Visible = true;
                textBoxApp.Visible = true;
            }
            else if (comboBoxAuto.SelectedIndex == 4)
            {
                label14.Visible = true;
                textBoxLen.Visible = true;
                label13.Visible = true;
                textBoxApp.Visible = true;
                label11.Visible = true;
                textBoxRoutes.Visible = true;
            }
        }
    }
}
