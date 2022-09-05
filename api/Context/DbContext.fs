namespace api.Context

open System.ComponentModel.DataAnnotations
open Microsoft.EntityFrameworkCore
open EntityFrameworkCore.FSharp.Extensions
open api.Models

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