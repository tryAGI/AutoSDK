//HintName: G.Models.BetaRequestImageBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaRequestImageBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestImageBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestImageBlockType value)
        {
            return value switch
            {
                BetaRequestImageBlockType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestImageBlockType? ToEnum(string value)
        {
            return value switch
            {
                "image" => BetaRequestImageBlockType.Image,
                _ => null,
            };
        }
    }
}