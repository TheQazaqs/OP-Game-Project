using System;

class Program
{
    static void Main(string[] args)
    {
        Store store = new Store();         // Создаём магазин
        ShoppingCart cart = new ShoppingCart();  // Создаём корзину

        bool running = true;

        while (running)
        {
            ShowMenu();  // Вывод основного меню
            string choice = Console.ReadLine();

            running = HandleChoice(choice, store, cart);  // Обработка выбора пользователя
        }

        Console.WriteLine("Спасибо за покупку!");
    }

    // Метод для вывода меню
    static void ShowMenu()
    {
        Console.WriteLine("\nДобро пожаловать в магазин!");
        Console.WriteLine("1. Показать товары");
        Console.WriteLine("2. Добавить товар в корзину");
        Console.WriteLine("3. Показать корзину");
        Console.WriteLine("4. Выйти");
        Console.Write("Выберите действие: ");
    }

    // Метод для обработки выбора пользователя
    static bool HandleChoice(string choice, Store store, ShoppingCart cart)
    {
        switch (choice)
        {
            case "1":
                store.ShowProducts();
                break;

            case "2":
                AddProductToCart(store, cart);
                break;

            case "3":
                cart.ShowCart();
                break;

            case "4":
                return false;  // Завершение работы

            default:
                Console.WriteLine("Некорректный выбор, попробуйте снова.");
                break;
        }
        return true;  // Продолжение работы
    }

    // Метод для добавления товара в корзину
    static void AddProductToCart(Store store, ShoppingCart cart)
    {
        store.ShowProducts();
        Console.Write("Введите номер товара для добавления: ");

        if (int.TryParse(Console.ReadLine(), out int productIndex))
        {
            var product = store.GetProduct(productIndex - 1);
            if (product != null)
            {
                cart.AddProduct(product);
            }
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректный номер.");
        }
    }
}
