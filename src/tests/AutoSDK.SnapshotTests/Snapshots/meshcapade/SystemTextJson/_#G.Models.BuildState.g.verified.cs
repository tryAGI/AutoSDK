//HintName: G.Models.BuildState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildState
    {
        /// <summary>
        /// 
        /// </summary>
        AwaitingInput,
        /// <summary>
        /// 
        /// </summary>
        AwaitingProcessing,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Preparing,
        /// <summary>
        /// 
        /// </summary>
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