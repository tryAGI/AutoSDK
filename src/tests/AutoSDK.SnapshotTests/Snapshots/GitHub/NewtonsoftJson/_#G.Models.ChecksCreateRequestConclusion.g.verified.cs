//HintName: G.Models.ChecksCreateRequestConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required if you provide `completed_at` or a `status` of `completed`**. The final conclusion of the check. <br/>
    /// **Note:** Providing `conclusion` will automatically set the `status` parameter to `completed`. You cannot change a check run conclusion to `stale`, only GitHub can set this.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChecksCreateRequestConclusion
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