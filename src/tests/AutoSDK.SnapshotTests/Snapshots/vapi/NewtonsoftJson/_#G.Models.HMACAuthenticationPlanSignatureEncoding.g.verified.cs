//HintName: G.Models.HMACAuthenticationPlanSignatureEncoding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The encoding format for the signature. Defaults to 'hex'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HMACAuthenticationPlanSignatureEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hex")]
        Hex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HMACAuthenticationPlanSignatureEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HMACAuthenticationPlanSignatureEncoding value)
        {
            return value switch
            {
                HMACAuthenticationPlanSignatureEncoding.Base64 => "base64",
                HMACAuthenticationPlanSignatureEncoding.Hex => "hex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HMACAuthenticationPlanSignatureEncoding? ToEnum(string value)
        {
            return value switch
            {
                "base64" => HMACAuthenticationPlanSignatureEncoding.Base64,
                "hex" => HMACAuthenticationPlanSignatureEncoding.Hex,
                _ => null,
            };
        }
    }
}