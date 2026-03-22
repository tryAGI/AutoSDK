//HintName: G.Models.CheckRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: neutral
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CheckRunConclusion
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
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
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
                CheckRunConclusion.ActionRequired => "action_required",
                CheckRunConclusion.Cancelled => "cancelled",
                CheckRunConclusion.Failure => "failure",
                CheckRunConclusion.Neutral => "neutral",
                CheckRunConclusion.Skipped => "skipped",
                CheckRunConclusion.Success => "success",
                CheckRunConclusion.TimedOut => "timed_out",
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
                "action_required" => CheckRunConclusion.ActionRequired,
                "cancelled" => CheckRunConclusion.Cancelled,
                "failure" => CheckRunConclusion.Failure,
                "neutral" => CheckRunConclusion.Neutral,
                "skipped" => CheckRunConclusion.Skipped,
                "success" => CheckRunConclusion.Success,
                "timed_out" => CheckRunConclusion.TimedOut,
                _ => null,
            };
        }
    }
}