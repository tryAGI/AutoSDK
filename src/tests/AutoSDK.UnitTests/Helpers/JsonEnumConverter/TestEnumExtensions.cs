using System;

namespace AutoSDK.JsonConverters;

public static class TestEnumExtensions
{
    public static string ToValueString(this TestEnum value)
    {
        return value switch
        {
            TestEnum.PullingManifest => "pulling manifest",
            TestEnum.Success => "success",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null),
        };
    }
    
    public static TestEnum? ToEnum(string value)
    {
        return value switch
        {
            "pulling manifest" => TestEnum.PullingManifest,
            "success" => TestEnum.Success,
            _ => null,
        };
    }
}