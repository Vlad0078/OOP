namespace lab_3
{
    interface IFigure
    {
        // ------------------- В-ті -------------------

        /// <summary>
        /// Площа фігури
        /// </summary>
        double Area { get; }

        /// <summary>
        /// Периметр фігури
        /// </summary>
        double Perimeter { get; }
    }
}
