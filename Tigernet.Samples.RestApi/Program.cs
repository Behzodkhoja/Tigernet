﻿using Tigernet.Hosting;
using Tigernet.Samples.RestApi.Clevers;
using Tigernet.Samples.RestApi.Clevers.Interfaces;

var builder = new TigernetHostBuilder("http://localhost:5000/");

builder.AddService<IUserEntityManager, UserEntityManager>();

builder.MapResters();

//builder.UseAsync(async (context) =>
//{
//    Console.WriteLine("Middleware 1");
//    await Task.CompletedTask;
//});

//builder.UseAsync(async (context) =>
//{
//    Console.WriteLine("Middleware 2");
//    await Task.CompletedTask;
//});

await builder.Start();

