//HintName: G.Models.SimulationRunSimulationEntryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type discriminator
    /// </summary>
    public enum SimulationRunSimulationEntryType
    {
        /// <summary>
        /// 
        /// </summary>
        Simulation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunSimulationEntryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunSimulationEntryType value)
        {
            return value switch
            {
                SimulationRunSimulationEntryType.Simulation => "simulation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunSimulationEntryType? ToEnum(string value)
        {
            return value switch
            {
                "simulation" => SimulationRunSimulationEntryType.Simulation,
                _ => null,
            };
        }
    }
}