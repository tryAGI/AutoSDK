//HintName: G.Models.ChecksUpdateRequestConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required if you provide `completed_at` or a `status` of `completed`**. The final conclusion of the check. <br/>
    /// **Note:** Providing `conclusion` will automatically set the `status` parameter to `completed`. You cannot change a check run conclusion to `stale`, only GitHub can set this.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChecksUpdateRequestConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="action_required")]
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// ** Providing `conclusion` will automatically set the `status` parameter to `completed`. You cannot change a check run conclusion to `stale`, only GitHub can set this.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stale")]
        Stale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChecksUpdateRequestConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksUpdateRequestConclusion value)
        {
            return value switch
            {
                ChecksUpdateRequestConclusion.ActionRequired => "action_required",
                ChecksUpdateRequestConclusion.Cancelled => "cancelled",
                ChecksUpdateRequestConclusion.Failure => "failure",
                ChecksUpdateRequestConclusion.Neutral => "neutral",
                ChecksUpdateRequestConclusion.Success => "success",
                ChecksUpdateRequestConclusion.Skipped => "skipped",
                ChecksUpdateRequestConclusion.Stale => "stale",
                ChecksUpdateRequestConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksUpdateRequestConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => ChecksUpdateRequestConclusion.ActionRequired,
                "cancelled" => ChecksUpdateRequestConclusion.Cancelled,
                "failure" => ChecksUpdateRequestConclusion.Failure,
                "neutral" => ChecksUpdateRequestConclusion.Neutral,
                "success" => ChecksUpdateRequestConclusion.Success,
                "skipped" => ChecksUpdateRequestConclusion.Skipped,
                "stale" => ChecksUpdateRequestConclusion.Stale,
                "timed_out" => ChecksUpdateRequestConclusion.TimedOut,
                _ => null,
            };
        }
    }
}