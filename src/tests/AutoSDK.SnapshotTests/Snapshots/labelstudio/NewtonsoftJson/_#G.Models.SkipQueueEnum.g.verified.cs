//HintName: G.Models.SkipQueueEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `REQUEUE_FOR_ME` - Requeue for me<br/>
    /// * `REQUEUE_FOR_OTHERS` - Requeue for others<br/>
    /// * `IGNORE_SKIPPED` - Ignore skipped
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SkipQueueEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IGNORE_SKIPPED")]
        IgnoreSkipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REQUEUE_FOR_ME")]
        RequeueForMe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REQUEUE_FOR_OTHERS")]
        RequeueForOthers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkipQueueEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkipQueueEnum value)
        {
            return value switch
            {
                SkipQueueEnum.IgnoreSkipped => "IGNORE_SKIPPED",
                SkipQueueEnum.RequeueForMe => "REQUEUE_FOR_ME",
                SkipQueueEnum.RequeueForOthers => "REQUEUE_FOR_OTHERS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkipQueueEnum? ToEnum(string value)
        {
            return value switch
            {
                "IGNORE_SKIPPED" => SkipQueueEnum.IgnoreSkipped,
                "REQUEUE_FOR_ME" => SkipQueueEnum.RequeueForMe,
                "REQUEUE_FOR_OTHERS" => SkipQueueEnum.RequeueForOthers,
                _ => null,
            };
        }
    }
}