//HintName: G.Models.ModelVariant11.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Balance of speed and intelligence
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-sonnet-20240229")]
        Claude3Sonnet20240229,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant11 value)
        {
            return value switch
            {
                ModelVariant11.Claude3Sonnet20240229 => "claude-3-sonnet-20240229",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant11? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-sonnet-20240229" => ModelVariant11.Claude3Sonnet20240229,
                _ => null,
            };
        }
    }
}