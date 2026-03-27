namespace AutoSDK.Models;

public readonly struct EnumNamingSettings
{
    public EnumNamingSettings(string clsCompliantEnumPrefix)
    {
        ClsCompliantEnumPrefix = clsCompliantEnumPrefix;
    }

    public string ClsCompliantEnumPrefix { get; }
}
