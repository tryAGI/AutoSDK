//HintName: G.Models.BetaSignatureContentBlockDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: signature_delta
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaSignatureContentBlockDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="signature_delta")]
        SignatureDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSignatureContentBlockDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSignatureContentBlockDeltaType value)
        {
            return value switch
            {
                BetaSignatureContentBlockDeltaType.SignatureDelta => "signature_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSignatureContentBlockDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "signature_delta" => BetaSignatureContentBlockDeltaType.SignatureDelta,
                _ => null,
            };
        }
    }
}