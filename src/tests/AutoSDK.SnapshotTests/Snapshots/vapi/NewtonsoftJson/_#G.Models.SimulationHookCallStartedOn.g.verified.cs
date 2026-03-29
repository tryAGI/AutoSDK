//HintName: G.Models.SimulationHookCallStartedOn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SimulationHookCallStartedOn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="simulation.run.started")]
        SimulationRunStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationHookCallStartedOnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationHookCallStartedOn value)
        {
            return value switch
            {
                SimulationHookCallStartedOn.SimulationRunStarted => "simulation.run.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationHookCallStartedOn? ToEnum(string value)
        {
            return value switch
            {
                "simulation.run.started" => SimulationHookCallStartedOn.SimulationRunStarted,
                _ => null,
            };
        }
    }
}