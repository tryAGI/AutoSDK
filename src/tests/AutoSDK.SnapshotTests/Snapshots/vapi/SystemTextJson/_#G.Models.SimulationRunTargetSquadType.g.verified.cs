//HintName: G.Models.SimulationRunTargetSquadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of target
    /// </summary>
    public enum SimulationRunTargetSquadType
    {
        /// <summary>
        /// 
        /// </summary>
        Squad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunTargetSquadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunTargetSquadType value)
        {
            return value switch
            {
                SimulationRunTargetSquadType.Squad => "squad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunTargetSquadType? ToEnum(string value)
        {
            return value switch
            {
                "squad" => SimulationRunTargetSquadType.Squad,
                _ => null,
            };
        }
    }
}