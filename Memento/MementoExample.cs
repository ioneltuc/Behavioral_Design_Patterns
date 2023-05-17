namespace TMPS_lab3.Memento
{
    public static class MementoExample
    {
        public static void StartExample()
        {
            var product = new Product("Pantaloni", "Jeans albastri", 500);
            var caretaker = new Caretaker(product);
            caretaker.Save();

            product.Description = "Jeans negri";
            product.Price = 450;
            caretaker.Save();

            product.Name = "Camasa";
            product.Description = "";
            product.Price = 399.99;
            caretaker.Save();

            caretaker.ShowHistory();

            caretaker.Undo();
            caretaker.Undo();

            caretaker.ShowHistory();
        }
    }
}