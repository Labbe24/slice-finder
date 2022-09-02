namespace api.Models

open System.ComponentModel.DataAnnotations
open Microsoft.EntityFrameworkCore
open EntityFrameworkCore.FSharp.Extensions

[<AllowNullLiteral>]
type Pizza() =
    [<DefaultValue>]
    val mutable private id: int

    member this.Id
        with get () = this.id
        and set (value) = this.id <- value

    [<DefaultValue>]
    val mutable private name: string

    member this.Title
        with get () = this.name
        and set (value) = this.name <- value

type CustomDbContext() =
    inherit DbContext()

    [<DefaultValue>]
    val mutable pizzas: DbSet<Pizza>

    member this.Pizzas
        with get () = this.pizzas
        and set v = this.pizzas <- v

    override _.OnModelCreating builder = builder.RegisterOptionTypes() // enables option values for all entities

    override __.OnConfiguring(options: DbContextOptionsBuilder) : unit =
        options.UseSqlite("Data Source=slice-finder.db")
        |> ignore
