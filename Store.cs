class Store  
{
    
    public List<Product> Products = new List<Product>();

    
    public Store()
    {
        
        Products.Add(new Product("Телефон", 100000, "Смартфон с большим экраном"));
        Products.Add(new Product("Ноутбук", 250000, "Мощный игровой ноутбук"));
        Products.Add(new Product("Наушники", 70000, "Беспроводные наушники"));
    }

    
    public void ShowProducts()
    {
        Console.WriteLine("Доступные товары:");  
        for (int i = 0; i < Products.Count; i++)
        {
            Console.Write($"{i + 1}. ");  
            Products[i].ShowInfo();  
        }
    }

    
    public Product GetProduct(int index)
    {
        
        if (index >= 0 && index < Products.Count)
        {
            return Products[index];  
        }
        else
        {
            
            Console.WriteLine("Некорректный номер товара.");
            return null;  
        }
    }
}Ы
