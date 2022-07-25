namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<Pizza[]> GetPizzasAsync()
    {
        return new Pizza[]{
            new Pizza { PizzaId = 1, Name = "Margherite", Description = "", Vegetarian = false, Vegan = false, Price = 14 },
            new Pizza { PizzaId = 2, Name = "Hawaiian", Description = "", Vegetarian = false, Vegan = false, Price = 11 },
            new Pizza { PizzaId = 3, Name = "Fiorentina", Description = "", Vegetarian = false, Vegan = false, Price = 10 },
            new Pizza { PizzaId = 4, Name = "Italiano", Description = "", Vegetarian = false, Vegan = false, Price = 12 },
            new Pizza { PizzaId = 5, Name = "Pepperoni", Description = "", Vegetarian = false, Vegan = false, Price = 14 }
        };
    }
}