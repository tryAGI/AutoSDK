//HintName: G.Models.ConsensusThreadStatusVariant3ConsensusThreadStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConsensusThreadStatusVariant3ConsensusThreadStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stopped_with_err")]
        StoppedWithErr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConsensusThreadStatusVariant3ConsensusThreadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsensusThreadStatusVariant3ConsensusThreadStatus value)
        {
            return value switch
            {
                ConsensusThreadStatusVariant3ConsensusThreadStatus.StoppedWithErr => "stopped_with_err",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsensusThreadStatusVariant3ConsensusThreadStatus? ToEnum(string value)
        {
            return value switch
            {
                "stopped_with_err" => ConsensusThreadStatusVariant3ConsensusThreadStatus.StoppedWithErr,
                _ => null,
            };
        }
    }
}