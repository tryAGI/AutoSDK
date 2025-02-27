//HintName: G.Models.BetaURLPDFSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaURLPDFSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaURLPDFSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaURLPDFSourceType value)
        {
            return value switch
            {
                BetaURLPDFSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaURLPDFSourceType? ToEnum(string value)
        {
            return value switch
            {
                "url" => BetaURLPDFSourceType.Url,
                _ => null,
            };
        }
    }
}