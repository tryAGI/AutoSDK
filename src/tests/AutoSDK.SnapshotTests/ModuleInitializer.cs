using System.Runtime.CompilerServices;

namespace AutoSDK.SnapshotTests;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Init()
    {
        VerifySourceGenerators.Initialize();

        // Set AUTOSDK_AUTO_VERIFY=true to auto-accept all snapshot changes
        // (useful after ordering/formatting changes that cause expected churn).
        if (Environment.GetEnvironmentVariable("AUTOSDK_AUTO_VERIFY") is "true" or "1")
        {
            VerifierSettings.AutoVerify();
        }
    }
}