# slice-finder

## Developer guide

### App

Run app

```
npm start
```

### Api

Run api

```
dotnet run
```

Add new migration

```
dotnet ef migrations add [name]
```

New migrations must manually be added to api.fsproj, inorder to be applied when updating the database.

Update database

```
dotnet ef database update
```

or

```
dotnet ef database update -v
```

for diagnosing

Drop database

```
dotnet ef database drop
```
