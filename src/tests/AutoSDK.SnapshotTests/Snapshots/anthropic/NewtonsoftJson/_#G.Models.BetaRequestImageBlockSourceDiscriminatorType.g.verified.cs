//HintName: G.Models.BetaRequestImageBlockSourceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaRequestImageBlockSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestImageBlockSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestImageBlockSourceDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestImageBlockSourceDiscriminatorType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestImageBlockSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => BetaRequestImageBlockSourceDiscriminatorType.Base64,
                _ => null,
            };
        }
    }
}