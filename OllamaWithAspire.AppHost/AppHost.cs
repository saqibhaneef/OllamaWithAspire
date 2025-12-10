var builder = DistributedApplication.CreateBuilder(args);

var ollama = builder.AddOllama("ollama")
               .WithDataVolume()
               .WithOpenWebUI();

ollama.AddModel("chat", "llama3.2");

builder.Build().Run();
