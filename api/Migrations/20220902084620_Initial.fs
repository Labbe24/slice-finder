﻿// <auto-generated />
namespace api.Migrations

open System
open Microsoft.EntityFrameworkCore
open Microsoft.EntityFrameworkCore.Infrastructure
open Microsoft.EntityFrameworkCore.Metadata
open Microsoft.EntityFrameworkCore.Migrations
open Microsoft.EntityFrameworkCore.Storage.ValueConversion

[<DbContext(typeof<PizzaModel.CustomDbContext>)>]
[<Migration("20220902084620_Initial")>]
type Initial() =
    inherit Migration()

    override this.Up(migrationBuilder:MigrationBuilder) =
        migrationBuilder.CreateTable(
            name = "Pizzas"
            ,columns = (fun table -> 
            {|
                Id =
                    table.Column<int>(
                        nullable = false
                        ,``type`` = "INTEGER"
                    ).Annotation("Sqlite:Autoincrement", true)
                Name =
                    table.Column<string>(
                        nullable = false
                        ,``type`` = "TEXT"
                    )
            |})
            , constraints =
                (fun table -> 
                    table.PrimaryKey("PK_Pizzas", (fun x -> (x.Id) :> obj)
                    ) |> ignore
                )
        ) |> ignore


    override this.Down(migrationBuilder:MigrationBuilder) =
        migrationBuilder.DropTable(
            name = "Pizzas"
            ) |> ignore


    override this.BuildTargetModel(modelBuilder: ModelBuilder) =
        modelBuilder.HasAnnotation("ProductVersion", "6.0.8") |> ignore

        modelBuilder.Entity("PizzaModel+Pizza", (fun b ->

            b.Property<int>("Id")
                .IsRequired(true)
                .ValueGeneratedOnAdd()
                .HasColumnType("INTEGER")
                |> ignore

            b.Property<string>("Name")
                .IsRequired(true)
                .HasColumnType("TEXT")
                |> ignore

            b.HasKey("Id")
                |> ignore


            b.ToTable("Pizzas") |> ignore

        )) |> ignore
