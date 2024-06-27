namespace Calculator
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="a">Первое слагаемое</param>
        /// <param name="b">Второе слагаемое</param>
        /// <returns>Сумма</returns>
        public int Additional(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="a">Уменьшаемое</param>
        /// <param name="b">Вычитаемое</param>
        /// <returns>Разность</returns>
        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="a">Первый множитель</param>
        /// <param name="b">Второй множитель</param>
        /// <returns>Произведение</returns>
        public int Miltiplication(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="a">Делимое</param>
        /// <param name="b">Делитель</param>
        /// <returns>Частное</returns>
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
