//HintName: G.Models.BuildState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BuildState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AWAITING_INPUT")]
        AwaitingInput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AWAITING_PROCESSING")]
        AwaitingProcessing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELED")]
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETED")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PREPARING")]
        Preparing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROCESSING")]
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildState value)
        {
            return value switch
            {
                BuildState.AwaitingInput => "AWAITING_INPUT",
                BuildState.AwaitingProcessing => "AWAITING_PROCESSING",
                BuildState.Canceled => "CANCELED",
                BuildState.Completed => "COMPLETED",
                BuildState.Error => "ERROR",
                BuildState.Pending => "PENDING",
                BuildState.Preparing => "PREPARING",
                BuildState.Processing => "PROCESSING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildState? ToEnum(string value)
        {
            return value switch
            {
                "AWAITING_INPUT" => BuildState.AwaitingInput,
                "AWAITING_PROCESSING" => BuildState.AwaitingProcessing,
                "CANCELED" => BuildState.Canceled,
                "COMPLETED" => BuildState.Completed,
                "ERROR" => BuildState.Error,
                "PENDING" => BuildState.Pending,
                "PREPARING" => BuildState.Preparing,
                "PROCESSING" => BuildState.Processing,
                _ => null,
            };
        }
    }
}