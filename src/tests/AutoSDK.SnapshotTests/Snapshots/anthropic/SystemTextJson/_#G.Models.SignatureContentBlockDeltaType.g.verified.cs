//HintName: G.Models.SignatureContentBlockDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: signature_delta
    /// </summary>
    public enum SignatureContentBlockDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        SignatureDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SignatureContentBlockDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignatureContentBlockDeltaType value)
        {
            return value switch
            {
                SignatureContentBlockDeltaType.SignatureDelta => "signature_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignatureContentBlockDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "signature_delta" => SignatureContentBlockDeltaType.SignatureDelta,
                _ => null,
            };
        }
    }
}