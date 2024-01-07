using System.Runtime.CompilerServices;

namespace OpenApiGenerator.SnapshotTests;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Init()
    {
        VerifySourceGenerators.Initialize();
    }
}