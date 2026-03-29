//HintName: G.Models.HMACAuthenticationPlanAlgorithm.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the HMAC algorithm to use for signing.
    /// </summary>
    public enum HMACAuthenticationPlanAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        Sha1,
        /// <summary>
        /// 
        /// </summary>
        Sha256,
        /// <summary>
        /// 
        /// </summary>
        Sha512,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HMACAuthenticationPlanAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HMACAuthenticationPlanAlgorithm value)
        {
            return value switch
            {
                HMACAuthenticationPlanAlgorithm.Sha1 => "sha1",
                HMACAuthenticationPlanAlgorithm.Sha256 => "sha256",
                HMACAuthenticationPlanAlgorithm.Sha512 => "sha512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HMACAuthenticationPlanAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "sha1" => HMACAuthenticationPlanAlgorithm.Sha1,
                "sha256" => HMACAuthenticationPlanAlgorithm.Sha256,
                "sha512" => HMACAuthenticationPlanAlgorithm.Sha512,
                _ => null,
            };
        }
    }
}