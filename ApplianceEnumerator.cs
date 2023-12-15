using System.Collections;
using System.Collections.Generic;

namespace Lab1._1
{
    /// <summary>
    /// Коллекция приборов
    /// </summary>
    internal class ApplianceEnumerator : IEnumerator<ElectricalAppliance>
    {
        /// <summary>
        /// Текущая позиция
        /// </summary>
        int position = -1;
        /// <summary>
        /// Список электроприборов
        /// </summary>
        List<ElectricalAppliance> electricalAppliances;
        /// <summary>
        /// Текущий элемент коллекции
        /// </summary>
        public ElectricalAppliance Current { get; set; }
        /// <summary>
        /// Конструктор для создания коллекции
        /// </summary>
        /// <param name="electricalAppliances">Список электроприборов</param>
        public ApplianceEnumerator(List<ElectricalAppliance> electricalAppliances) => this.electricalAppliances = electricalAppliances;
        /// <summary>
        /// Конструктор для создания коллекции
        /// </summary>
        public ApplianceEnumerator() => this.electricalAppliances = new List<ElectricalAppliance>();

        object IEnumerator.Current
        {
            get
            {
                if (position == -1 || position >= electricalAppliances.Count - 1)
                    throw new ArgumentException();
                return electricalAppliances[position];
            }
        }

        public bool MoveNext()
        {
            if (position < electricalAppliances.Count - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset() => position = -1;

        public void Dispose()
        {
            electricalAppliances.Clear();
        }
        /// <summary>
        /// Подсчёт энергопотребления
        /// </summary>
        /// <returns>Энергопотребление</returns>
        public int PowerDraw() 
        {
            int sum = 0;

            foreach (var item in electricalAppliances) 
            {
                sum += item.ConsumablePower;
            }

            return sum;
        }
        /// <summary>
        /// Сортировка по потребляемой мощности
        /// </summary>
        /// <param name="desc">По убыванию</param>
        public void Sort(bool desc = false) 
        {
            if (desc) 
            {
                electricalAppliances = electricalAppliances.OrderByDescending(e => e.ConsumablePower).ToList();
            }
            else 
            {
                electricalAppliances = electricalAppliances.OrderBy(e => e.ConsumablePower).ToList();
            }
        }
        /// <summary>
        /// Найти приборы подходящие под условия
        /// </summary>
        /// <param name="plugged">Включен ли прибор</param>
        /// <param name="power">Потребляемая мощность</param>
        /// <param name="name">Название</param>
        /// <returns>Коллекцию электроприборов</returns>
        public ApplianceEnumerator? Find(bool plugged, int power, string name) 
        {
            var founded = electricalAppliances.FindAll(
                e => e.ConsumablePower == power 
                                 || e.Name == name
                                 || e.Plugged == plugged 
                );

            return new ApplianceEnumerator(founded);
        }
        /// <summary>
        /// Добавление элемента в коллекцию
        /// </summary>
        /// <param name="electricalAppliance">Электроприбор</param>
        public void Append(ElectricalAppliance electricalAppliance) {
            electricalAppliances.Add(electricalAppliance);
        }

        override
        public string ToString() {
            var result = "";
            foreach (var item in electricalAppliances) {
                result += item.ToString() + "\n";
            }
            return result;
        }
    }
}
