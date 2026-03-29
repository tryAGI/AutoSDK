//HintName: G.Models.CreateExpressiveRequestDtoScriptVariant1ProviderAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateExpressiveRequestDtoScriptVariant1ProviderAmazonType
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
    public static class CreateExpressiveRequestDtoScriptVariant1ProviderAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressiveRequestDtoScriptVariant1ProviderAmazonType value)
        {
            return value switch
            {
                CreateExpressiveRequestDtoScriptVariant1ProviderAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressiveRequestDtoScriptVariant1ProviderAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => CreateExpressiveRequestDtoScriptVariant1ProviderAmazonType.Amazon,
                _ => null,
            };
        }
    }
}