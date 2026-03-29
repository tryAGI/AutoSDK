//HintName: G.Models.ConsensusThreadStatusVariant1ConsensusThreadStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConsensusThreadStatusVariant1ConsensusThreadStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Working,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConsensusThreadStatusVariant1ConsensusThreadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsensusThreadStatusVariant1ConsensusThreadStatus value)
        {
            return value switch
            {
                ConsensusThreadStatusVariant1ConsensusThreadStatus.Working => "working",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsensusThreadStatusVariant1ConsensusThreadStatus? ToEnum(string value)
        {
            return value switch
            {
                "working" => ConsensusThreadStatusVariant1ConsensusThreadStatus.Working,
                _ => null,
            };
        }
    }
}