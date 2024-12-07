//HintName: G.Models.BetaCacheControlEphemeralType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCacheControlEphemeralType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCacheControlEphemeralTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCacheControlEphemeralType value)
        {
            return value switch
            {
                BetaCacheControlEphemeralType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCacheControlEphemeralType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => BetaCacheControlEphemeralType.Ephemeral,
                _ => null,
            };
        }
    }
}