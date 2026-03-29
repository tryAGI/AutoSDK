//HintName: G.Models.SimulationHookCallEndedOn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SimulationHookCallEndedOn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="simulation.run.ended")]
        SimulationRunEnded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationHookCallEndedOnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationHookCallEndedOn value)
        {
            return value switch
            {
                SimulationHookCallEndedOn.SimulationRunEnded => "simulation.run.ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationHookCallEndedOn? ToEnum(string value)
        {
            return value switch
            {
                "simulation.run.ended" => SimulationHookCallEndedOn.SimulationRunEnded,
                _ => null,
            };
        }
    }
}