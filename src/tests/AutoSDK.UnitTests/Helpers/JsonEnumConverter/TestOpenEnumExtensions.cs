namespace AutoSDK.JsonConverters;

public static class TestOpenEnumExtensions
{
    public static string ToValueString(this TestOpenEnum value)
    {
        return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
    }

    public static TestOpenEnum? ToEnum(string value)
    {
        return TestOpenEnum.FromValue(value);
    }
}
