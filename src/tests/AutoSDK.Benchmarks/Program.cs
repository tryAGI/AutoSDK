using AutoSDK.Benchmarks;
using BenchmarkDotNet.Running;

if (args.Length > 0 && args[0] == "--profile")
{
    BenchmarkProfileRunner.Run();
}
else if (args.Length > 0 && args[0] == "--profile-methods")
{
    BenchmarkProfileRunner.RunMethodRendering();
}
else if (args.Length > 0 && args[0] == "--profile-data")
{
    BenchmarkProfileRunner.RunDataComputation(args.ElementAtOrDefault(1));
}
else if (args.Length > 0 && args[0] == "--profile-naming")
{
    BenchmarkProfileRunner.RunModelNaming();
}
else if (args.Length > 0 && args[0] == "--profile-unions")
{
    BenchmarkProfileRunner.RunUnionRendering();
}
else if (args.Length > 0 && args[0] == "--profile-enrichment")
{
    BenchmarkProfileRunner.RunDataEnrichment(args.ElementAtOrDefault(1));
}
else
{
    BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
}
