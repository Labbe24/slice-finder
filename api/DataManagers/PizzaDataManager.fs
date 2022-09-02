namespace api.DataManagers

open System.Threading.Tasks
open api.Models
open System

type IPizzaDataManager =
    interface
        abstract member GetPizza : int -> Pizza Task
        abstract member GetPizzas : unit -> Pizza list Task
        abstract member CreatePizza : Pizza -> Task<Pizza>
    end

type PizzaDataManager(context : CustomDbContext) =
    interface IPizzaDataManager with
        member this.GetPizza id =
            let query = context.Pizzas |> Seq.tryFind (fun q -> q.Id = id)

            let pizza =
                match query with
                | Some i -> i
                | None -> null

            let asyncQuery = async {
                return pizza
            }
            Async.StartAsTask(asyncQuery)

        member this.GetPizzas () =
            let query = async {
                return context.Pizzas |> Seq.toList
            }
            Async.StartAsTask(query)

        member this.CreatePizza pizza =
            let query = async {
                context.Pizzas.Add(pizza) |> ignore
                context.SaveChanges true |> ignore
                return pizza
            }
            Async.StartAsTask(query)