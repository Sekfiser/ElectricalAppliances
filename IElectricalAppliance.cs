namespace Lab1._1
{
    /// <summary>
    /// Интерфейс элетроприбора
    /// </summary>
    internal interface IElectricalAppliance
    {
        /// <summary>
        /// Название прибора
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Потребляемая энергия
        /// </summary>
        int ConsumablePower { get; set; }
        /// <summary>
        /// Включен ли прибор
        /// </summary>
        bool  IsOn { get; }
        /// <summary>
        /// Включен ли прибор в розетку
        /// </summary>
        bool  Plugged { get; }
        /// <summary>
        /// Включить в розетку
        /// </summary>
        /// <returns></returns>
        bool PlugIn();
        /// <summary>
        /// Выключить из розетки
        /// </summary>
        /// <returns></returns>
        bool PlugOut();
        /// <summary>
        /// Включить
        /// </summary>
        /// <returns></returns>
        bool TurnOn();
        /// <summary>
        /// Выключить
        /// </summary>
        /// <returns></returns>
        bool TurnOff();
    }
}
