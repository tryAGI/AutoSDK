//HintName: G.Models.RelayTargetSquadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of relay target
    /// </summary>
    public enum RelayTargetSquadType
    {
        /// <summary>
        /// 
        /// </summary>
        Squad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RelayTargetSquadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RelayTargetSquadType value)
        {
            return value switch
            {
                RelayTargetSquadType.Squad => "squad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RelayTargetSquadType? ToEnum(string value)
        {
            return value switch
            {
                "squad" => RelayTargetSquadType.Squad,
                _ => null,
            };
        }
    }
}