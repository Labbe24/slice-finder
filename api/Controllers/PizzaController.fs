namespace api.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open api.Logic
open api.Models

[<ApiController>]
[<Route("[controller]")>]
type PizzaController(pizzaLogic: IPizzaLogic, logger: ILogger<PizzaController>) =
    inherit ControllerBase()


    [<HttpGet>]
    member this.Get() =
        let pizzas = pizzaLogic.GetPizzas()
        ActionResult<Pizza list>(pizzas)

    [<HttpGet("{id}")>]
    member this.Get(id: int) =
        let pizza = pizzaLogic.GetPizza(id)
        ActionResult<Pizza>(pizza)

    [<HttpPost>]
    member this.Post([<FromBody>] pizza: Pizza) =
        match base.ModelState.IsValid with
        | false -> ActionResult<IActionResult>(base.BadRequest())
        | true ->
            pizzaLogic.CreatePizza(pizza) |> ignore
            ActionResult<IActionResult>(base.Ok(pizza))
