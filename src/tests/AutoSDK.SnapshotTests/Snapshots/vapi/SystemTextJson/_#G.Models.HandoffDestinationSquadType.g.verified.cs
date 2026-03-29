//HintName: G.Models.HandoffDestinationSquadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum HandoffDestinationSquadType
    {
        /// <summary>
        /// 
        /// </summary>
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