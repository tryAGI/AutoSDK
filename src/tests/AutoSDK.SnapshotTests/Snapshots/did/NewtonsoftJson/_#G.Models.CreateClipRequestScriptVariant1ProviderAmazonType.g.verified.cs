//HintName: G.Models.CreateClipRequestScriptVariant1ProviderAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipRequestScriptVariant1ProviderAmazonType
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
    public static class CreateClipRequestScriptVariant1ProviderAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestScriptVariant1ProviderAmazonType value)
        {
            return value switch
            {
                CreateClipRequestScriptVariant1ProviderAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestScriptVariant1ProviderAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => CreateClipRequestScriptVariant1ProviderAmazonType.Amazon,
                _ => null,
            };
        }
    }
}