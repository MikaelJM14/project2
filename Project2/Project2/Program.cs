using Microsoft.Extensions.DependencyInjection;
using Project2;
using Project2.CSV;

var seviceCollection = new ServiceCollection();
seviceCollection.AddSingleton<IApplication, Application>();
seviceCollection.AddSingleton<ICsvread, Csvread>();

var seviceProvier = seviceCollection.BuildServiceProvider();
var application = seviceProvier.GetService<IApplication>()!;
application?.activate();