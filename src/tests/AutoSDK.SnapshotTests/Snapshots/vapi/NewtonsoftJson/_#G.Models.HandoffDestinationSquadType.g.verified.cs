//HintName: G.Models.HandoffDestinationSquadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HandoffDestinationSquadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="squad")]
        Squad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HandoffDestinationSquadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HandoffDestinationSquadType value)
        {
            return value switch
            {
                HandoffDestinationSquadType.Squad => "squad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HandoffDestinationSquadType? ToEnum(string value)
        {
            return value switch
            {
                "squad" => HandoffDestinationSquadType.Squad,
                _ => null,
            };
        }
    }
}