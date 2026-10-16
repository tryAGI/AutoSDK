using System.Runtime.CompilerServices;

namespace AutoSDK.SnapshotTests;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Init()
    {
        VerifySourceGenerators.Initialize();
        // Keep snapshots compatible with the repository's UTF-8 without BOM baselines.
        VerifierSettings.UseUtf8NoBom();

    }
}
