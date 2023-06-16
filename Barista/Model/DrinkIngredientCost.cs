namespace Barista.Model
{
    public enum DrinkIngredient : ushort
    {
        Coffee = 0,
        Cocoa,
        Chocolate,
        Sugar,
        Milk,
        Cream
    }

    public static class DrinkIngredientCost
    {
        private static double _coffee    = 205;
        private static double _cocoa     = 240;
        private static double _chocolate = 260;
        private static double _sugar     = 10;
        private static double _milk      = 25;
        private static double _cream     = 40;
        
        public static double Coffee    { get { return _coffee;    } }
        public static double Cocoa     { get { return _cocoa;     } }
        public static double Chocolate { get { return _chocolate; } }
        public static double Sugar     { get { return _sugar;     } }
        public static double Milk      { get { return _milk;      } }
        public static double Cream     { get { return _cream;     } }

    }
}
