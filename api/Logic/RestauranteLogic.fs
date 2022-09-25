namespace api.Logic

open System.Threading.Tasks
open api.DataManagers
open api.Models
open System

type IRestauranteLogic =
    interface
        abstract member GetRestaurante: int -> Restaurante
        abstract member GetRestaurantes: unit -> Restaurante list
        abstract member CreateRestaurante: Restaurante -> Restaurante
    end

type RestauranteLogic(restauranteDataManager: IRestauranteDataManager) =
    interface IRestauranteLogic with
        member this.GetRestaurante id =
            let restaurante = restauranteDataManager.GetRestaurante(id)
            restaurante.Result

        member this.GetRestaurantes() =
            let restaurantes = restauranteDataManager.GetRestaurantes()
            restaurantes.Result

        member this.CreateRestaurante restaurante =
            let restaurante = restauranteDataManager.CreateRestaurante(restaurante)
            restaurante.Result
