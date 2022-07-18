using Microsoft.EntityFrameworkCore;
using ContosoPizza.Models;

namespace ContosoPizza.Data;

public class PizzaContext : DbContext{

    //constructor accepts param DbContextOptions.
    //Allows for external code to pass in the config
    public PizzaContext(DbContextOptions<PizzaContext> options)
        : base(options)
        {
        }
        //DbSet<T> properties corrospond to tables to be created in the db
        public DbSet<Pizza> Pizzas => Set<Pizza>();
        public DbSet<Topping> Toppings => Set<Topping>();
        public DbSet<Sauce> Sauces => Set<Sauce>();

        

    

}