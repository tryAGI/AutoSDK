namespace AutoSDK.Models;

public readonly struct SchemaNamingSettings
{
    public SchemaNamingSettings(string clsCompliantEnumPrefix, bool useExtensionNaming)
    {
        ClsCompliantEnumPrefix = clsCompliantEnumPrefix;
        UseExtensionNaming = useExtensionNaming;
    }

    public string ClsCompliantEnumPrefix { get; }
    public bool UseExtensionNaming { get; }
}
