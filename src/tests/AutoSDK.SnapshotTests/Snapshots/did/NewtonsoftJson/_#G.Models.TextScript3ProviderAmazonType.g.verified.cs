//HintName: G.Models.TextScript3ProviderAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextScript3ProviderAmazonType
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
    public static class TextScript3ProviderAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextScript3ProviderAmazonType value)
        {
            return value switch
            {
                TextScript3ProviderAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextScript3ProviderAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => TextScript3ProviderAmazonType.Amazon,
                _ => null,
            };
        }
    }
}