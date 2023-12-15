namespace Lab1._1
{
    /// <summary>
    /// Электроприбор
    /// </summary>
    internal abstract class ElectricalAppliance : IElectricalAppliance
    {
        /// <summary>
        /// Конструктор электроприбора
        /// </summary>
        public ElectricalAppliance()
        {
            IsOn = false;
            Plugged = false;
            var rnd = new Random();
            this.ConsumablePower = rnd.Next(10, 220);
            this.Plugged = Convert.ToBoolean(rnd.Next(0, 2));
            this.IsOn = Convert.ToBoolean(rnd.Next(0, 2));
        }
        /// <summary>
        /// Конструктор элетроприбора
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="consumablePower">Потребляемая мощность</param>
        public ElectricalAppliance(string name, int consumablePower)
        {
            IsOn = false;
            Plugged = false;
            this.Name = name;
            this.ConsumablePower = consumablePower;
        }

        public string Name { get; set; }
        public int ConsumablePower { get; set; }

        public bool IsOn { get; private set; }

        public bool Plugged { get; private set; }

        public bool PlugIn()
        {
            if (Plugged)
            {
                return false;
            }
            else
            {
                Plugged = true;
                return true;
            }
        }

        public bool PlugOut()
        {
            if (!Plugged)
            {
                return false;
            }
            else
            {
                Plugged = false;
                return true;
            }
        }

        public bool TurnOff()
        {
            if (!IsOn)
            {
                return false;
            }
            else
            {
                IsOn = false;
                return true;
            }
        }

        public bool TurnOn()
        {
            if (IsOn)
            {
                return false;
            }
            else
            {
                IsOn = true;
                return true;
            }
        }
        /// <summary>
        /// Вывод элетроприбора
        /// </summary>
        /// <returns>Содержание объекта электроприбора</returns>
        override
        public string ToString() {
            return $"Name = {this.Name}, Power = {this.ConsumablePower}, Plugged = {this.Plugged}, Working = {this.IsOn}";
        }
    }
}
