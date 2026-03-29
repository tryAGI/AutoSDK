//HintName: G.Models.SimulationRunSuiteEntryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type discriminator
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SimulationRunSuiteEntryType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="simulationSuite")]
        SimulationSuite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunSuiteEntryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunSuiteEntryType value)
        {
            return value switch
            {
                SimulationRunSuiteEntryType.SimulationSuite => "simulationSuite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunSuiteEntryType? ToEnum(string value)
        {
            return value switch
            {
                "simulationSuite" => SimulationRunSuiteEntryType.SimulationSuite,
                _ => null,
            };
        }
    }
}