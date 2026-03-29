//HintName: G.Models.AmazonTtsProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AmazonTtsProviderType
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
    public static class AmazonTtsProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AmazonTtsProviderType value)
        {
            return value switch
            {
                AmazonTtsProviderType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AmazonTtsProviderType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => AmazonTtsProviderType.Amazon,
                _ => null,
            };
        }
    }
}