namespace AutoSDK.Internal;

/// <summary>Source-linked contract shared by the producer and build-only metadata analyzer.</summary>
internal static class SharedJsonMetadataProtocol
{
    internal const int CurrentVersion = 1;
    internal const string HeaderPrefix = "// AutoSDK.JsonMetadata manifest-format: ";
    internal const string GeneratedProtocolTypeName = "global::AutoSDK.JsonMetadata.Generated.ManifestProtocol";

    internal static string FactoryHolderName(string contextName, string typeInfoName) =>
        contextName + "Factory_" + typeInfoName;
}
