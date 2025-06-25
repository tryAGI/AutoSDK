//HintName: G.Models.ChecksCreateRequestConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required if you provide `completed_at` or a `status` of `completed`**. The final conclusion of the check. <br/>
    /// **Note:** Providing `conclusion` will automatically set the `status` parameter to `completed`. You cannot change a check run conclusion to `stale`, only GitHub can set this.
    /// </summary>
    public enum ChecksCreateRequestConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
        Success,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// ** Providing `conclusion` will automatically set the `status` parameter to `completed`. You cannot change a check run conclusion to `stale`, only GitHub can set this.
        /// </summary>
        Stale,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChecksCreateRequestConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksCreateRequestConclusion value)
        {
            return value switch
            {
                ChecksCreateRequestConclusion.ActionRequired => "action_required",
                ChecksCreateRequestConclusion.Cancelled => "cancelled",
                ChecksCreateRequestConclusion.Failure => "failure",
                ChecksCreateRequestConclusion.Neutral => "neutral",
                ChecksCreateRequestConclusion.Success => "success",
                ChecksCreateRequestConclusion.Skipped => "skipped",
                ChecksCreateRequestConclusion.Stale => "stale",
                ChecksCreateRequestConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksCreateRequestConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => ChecksCreateRequestConclusion.ActionRequired,
                "cancelled" => ChecksCreateRequestConclusion.Cancelled,
                "failure" => ChecksCreateRequestConclusion.Failure,
                "neutral" => ChecksCreateRequestConclusion.Neutral,
                "success" => ChecksCreateRequestConclusion.Success,
                "skipped" => ChecksCreateRequestConclusion.Skipped,
                "stale" => ChecksCreateRequestConclusion.Stale,
                "timed_out" => ChecksCreateRequestConclusion.TimedOut,
                _ => null,
            };
        }
    }
}