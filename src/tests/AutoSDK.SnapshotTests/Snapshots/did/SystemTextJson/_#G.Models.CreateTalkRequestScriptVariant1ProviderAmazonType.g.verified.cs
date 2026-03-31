//HintName: G.Models.CreateTalkRequestScriptVariant1ProviderAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTalkRequestScriptVariant1ProviderAmazonType
    {
        /// <summary>
        /// 
        /// </summary>
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTalkRequestScriptVariant1ProviderAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestScriptVariant1ProviderAmazonType value)
        {
            return value switch
            {
                CreateTalkRequestScriptVariant1ProviderAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestScriptVariant1ProviderAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => CreateTalkRequestScriptVariant1ProviderAmazonType.Amazon,
                _ => null,
            };
        }
    }
}