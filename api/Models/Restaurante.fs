namespace api.Models

open System.ComponentModel.DataAnnotations
open Microsoft.EntityFrameworkCore
open EntityFrameworkCore.FSharp.Extensions

[<AllowNullLiteral>]
type Restaurante() =
    [<DefaultValue>]
    val mutable private id: int

    member this.Id
        with get () = this.id
        and set (value) = this.id <- value

    [<DefaultValue>]
    val mutable private name: string

    member this.Name
        with get () = this.name
        and set (value) = this.name <- value
