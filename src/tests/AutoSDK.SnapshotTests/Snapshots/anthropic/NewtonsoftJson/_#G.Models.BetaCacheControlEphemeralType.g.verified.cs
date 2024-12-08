//HintName: G.Models.BetaCacheControlEphemeralType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaCacheControlEphemeralType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ephemeral")]
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