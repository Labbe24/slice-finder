namespace api.Logic

open System.Threading.Tasks
open api.DataManagers
open api.Models
open System

type IPizzaLogic =
    interface
        abstract member GetPizza: int -> Pizza
        abstract member GetPizzas: unit -> Pizza list
        abstract member CreatePizza: Pizza -> Pizza
    end

type PizzaLogic(pizzaDataManager: IPizzaDataManager) =
    interface IPizzaLogic with
        member this.GetPizza id =
            let pizza = pizzaDataManager.GetPizza(id)
            pizza.Result

        member this.GetPizzas() =
            let pizzas = pizzaDataManager.GetPizzas()
            pizzas.Result

        member this.CreatePizza pizza =
            let pizza = pizzaDataManager.CreatePizza(pizza)
            pizza.Result
