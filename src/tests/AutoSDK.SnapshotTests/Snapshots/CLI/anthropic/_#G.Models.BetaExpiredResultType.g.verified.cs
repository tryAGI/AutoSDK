//HintName: G.Models.BetaExpiredResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: expired
    /// </summary>
    public enum BetaExpiredResultType
    {
        /// <summary>
        /// 
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaExpiredResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaExpiredResultType value)
        {
            return value switch
            {
                BetaExpiredResultType.Expired => "expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaExpiredResultType? ToEnum(string value)
        {
            return value switch
            {
                "expired" => BetaExpiredResultType.Expired,
                _ => null,
            };
        }
    }
}