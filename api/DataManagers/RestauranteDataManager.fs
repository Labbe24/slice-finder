namespace api.DataManagers

open System.Threading.Tasks
open api.Models
open api.Context
open System

type IRestauranteDataManager =
    interface
        abstract member GetRestaurante: int -> Restaurante Task
        abstract member GetRestaurantes: unit -> Restaurante list Task
        abstract member CreateRestaurante: Restaurante -> Task<Restaurante>
    end

type RestauranteDataManager(context: CustomDbContext) =
    interface IRestauranteDataManager with
        member this.GetRestaurante id =
            let query = context.Restaurantes |> Seq.tryFind (fun q -> q.Id = id)

            let restaurante =
                match query with
                | Some i -> i
                | None -> null

            let asyncQuery = async { return restaurante }
            Async.StartAsTask(asyncQuery)

        member this.GetRestaurantes() =
            let query = async { return context.Restaurantes |> Seq.toList }
            Async.StartAsTask(query)

        member this.CreateRestaurante restaurante =
            let query =
                async {
                    context.Restaurantes.Add(restaurante) |> ignore
                    context.SaveChanges true |> ignore
                    return restaurante
                }

            Async.StartAsTask(query)
