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
    member this.Get() : IActionResult =
        let pizzas = pizzaLogic.GetPizzas
        pizzas |> this.Ok :> IActionResult
