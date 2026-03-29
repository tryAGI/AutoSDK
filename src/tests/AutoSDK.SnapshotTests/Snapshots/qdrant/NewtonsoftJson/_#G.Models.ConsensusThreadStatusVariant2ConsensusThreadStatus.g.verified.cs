//HintName: G.Models.ConsensusThreadStatusVariant2ConsensusThreadStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConsensusThreadStatusVariant2ConsensusThreadStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stopped")]
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConsensusThreadStatusVariant2ConsensusThreadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsensusThreadStatusVariant2ConsensusThreadStatus value)
        {
            return value switch
            {
                ConsensusThreadStatusVariant2ConsensusThreadStatus.Stopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsensusThreadStatusVariant2ConsensusThreadStatus? ToEnum(string value)
        {
            return value switch
            {
                "stopped" => ConsensusThreadStatusVariant2ConsensusThreadStatus.Stopped,
                _ => null,
            };
        }
    }
}