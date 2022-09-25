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
[<Route("api/[controller]")>]
type RestauranteController(restauranteLogic: IRestauranteLogic, logger: ILogger<RestauranteController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member this.Get() =
        let restaurantes = restauranteLogic.GetRestaurantes()
        ActionResult<Restaurante list>(restaurantes)

    [<HttpGet("{id}")>]
    member this.Get(id: int) =
        let restaurante = restauranteLogic.GetRestaurante(id)
        ActionResult<Restaurante>(restaurante)

    [<HttpPost>]
    member this.Post([<FromBody>] restaurante: Restaurante) =
        match base.ModelState.IsValid with
        | false -> ActionResult<Restaurante>(``base``.BadRequest(restaurante))
        | true ->
            restauranteLogic.CreateRestaurante(restaurante) |> ignore
            ActionResult<Restaurante>(``base``.Ok(restaurante))
