//HintName: G.Models.ProvidersStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProvidersStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Exhausted,
        /// <summary>
        /// 
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProvidersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvidersStatus value)
        {
            return value switch
            {
                ProvidersStatus.Active => "active",
                ProvidersStatus.Exhausted => "exhausted",
                ProvidersStatus.Expired => "expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvidersStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ProvidersStatus.Active,
                "exhausted" => ProvidersStatus.Exhausted,
                "expired" => ProvidersStatus.Expired,
                _ => null,
            };
        }
    }
}