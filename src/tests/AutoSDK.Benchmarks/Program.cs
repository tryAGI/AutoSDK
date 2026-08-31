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
    BenchmarkProfileRunner.RunDataComputation();
}
else if (args.Length > 0 && args[0] == "--profile-naming")
{
    BenchmarkProfileRunner.RunModelNaming();
}
else
{
    BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
}
