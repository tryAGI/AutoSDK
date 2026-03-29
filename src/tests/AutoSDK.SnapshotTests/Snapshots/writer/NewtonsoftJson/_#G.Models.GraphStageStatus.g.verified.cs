//HintName: G.Models.GraphStageStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraphStageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="finished")]
        Finished,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphStageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphStageStatus value)
        {
            return value switch
            {
                GraphStageStatus.Finished => "finished",
                GraphStageStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphStageStatus? ToEnum(string value)
        {
            return value switch
            {
                "finished" => GraphStageStatus.Finished,
                "processing" => GraphStageStatus.Processing,
                _ => null,
            };
        }
    }
}