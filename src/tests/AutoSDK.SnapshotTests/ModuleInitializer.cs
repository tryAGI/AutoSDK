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

        // Set AUTOSDK_AUTO_VERIFY=true to auto-accept all snapshot changes
        // (useful after ordering/formatting changes that cause expected churn).
        if (Environment.GetEnvironmentVariable("AUTOSDK_AUTO_VERIFY") is "true" or "1")
        {
            VerifierSettings.AutoVerify();
        }
    }
}
