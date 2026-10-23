namespace AutoSDK.Internal;

/// <summary>Source-linked contract shared by the producer and build-only metadata analyzer.</summary>
internal static class SharedJsonMetadataProtocol
{
    internal const int CurrentVersion = 3;
    internal const int FactoryBatchSize = 16;
    internal const string BatchPrefix = "// AutoSDK.JsonMetadata factory-batch: ";
    internal const string HeaderPrefix = "// AutoSDK.JsonMetadata manifest-format: ";
    internal const string GeneratedProtocolTypeName = "global::AutoSDK.JsonMetadata.Generated.ManifestProtocol";

    internal static string FactoryBatchHolderName(string contextName, int index) =>
        contextName + "FactoryBatch" + index.ToString("D4", System.Globalization.CultureInfo.InvariantCulture);

    internal static string ImplicitFactoryBatchHolderName(string contextName, int index) =>
        contextName + "FactoryBatchImplicit" + index.ToString("D4", System.Globalization.CultureInfo.InvariantCulture);

    internal static string FactoryHolderName(string contextName, string typeInfoName) =>
        contextName + "Factory_" + typeInfoName;
}
