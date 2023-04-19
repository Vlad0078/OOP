namespace lab_3
{
    interface ITriangle : IFigure
    {
        // ------------------- В-ті -------------------
        double SideA { get; }
        double SideB { get; }
        double SideC { get; }


        // ------------------- Ф-ції -------------------

        /// <summary>
        /// Обраховує радіус кола, вписаного в цей трикутник
        /// </summary>
        /// <returns>Радіус вписаного кола</returns>
        double GetInCircleRadius();

        /// <summary>
        /// Обраховує радіус кола, описаного навколо цього трикутника
        /// </summary>
        /// <returns>Радіус описаного кола</returns>
        double GetCircumCircleRadius();
    }
}
