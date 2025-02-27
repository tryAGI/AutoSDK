//HintName: G.Models.ModelVariant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Our previous most fast and cost-effective
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-haiku-20240307")]
        Claude3Haiku20240307,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant12 value)
        {
            return value switch
            {
                ModelVariant12.Claude3Haiku20240307 => "claude-3-haiku-20240307",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant12? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-haiku-20240307" => ModelVariant12.Claude3Haiku20240307,
                _ => null,
            };
        }
    }
}