//HintName: G.Models.CheckRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: neutral
    /// </summary>
    public enum CheckRunConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        ActionRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckRunConclusion value)
        {
            return value switch
            {
                CheckRunConclusion.Success => "success",
                CheckRunConclusion.Failure => "failure",
                CheckRunConclusion.Neutral => "neutral",
                CheckRunConclusion.Cancelled => "cancelled",
                CheckRunConclusion.Skipped => "skipped",
                CheckRunConclusion.TimedOut => "timed_out",
                CheckRunConclusion.ActionRequired => "action_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "success" => CheckRunConclusion.Success,
                "failure" => CheckRunConclusion.Failure,
                "neutral" => CheckRunConclusion.Neutral,
                "cancelled" => CheckRunConclusion.Cancelled,
                "skipped" => CheckRunConclusion.Skipped,
                "timed_out" => CheckRunConclusion.TimedOut,
                "action_required" => CheckRunConclusion.ActionRequired,
                _ => null,
            };
        }
    }
}