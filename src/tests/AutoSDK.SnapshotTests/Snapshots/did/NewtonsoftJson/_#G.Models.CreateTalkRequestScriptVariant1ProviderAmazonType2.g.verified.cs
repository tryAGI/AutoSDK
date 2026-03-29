//HintName: G.Models.CreateTalkRequestScriptVariant1ProviderAmazonType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkRequestScriptVariant1ProviderAmazonType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="amazon")]
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTalkRequestScriptVariant1ProviderAmazonType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestScriptVariant1ProviderAmazonType2 value)
        {
            return value switch
            {
                CreateTalkRequestScriptVariant1ProviderAmazonType2.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestScriptVariant1ProviderAmazonType2? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => CreateTalkRequestScriptVariant1ProviderAmazonType2.Amazon,
                _ => null,
            };
        }
    }
}