//HintName: G.Models.RequeueRejectedTasksModeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `requeue` - Requeue<br/>
    /// * `remove` - Remove<br/>
    /// * `flexible` - Flexible
    /// </summary>
    public enum RequeueRejectedTasksModeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Flexible,
        /// <summary>
        /// 
        /// </summary>
        Remove,
        /// <summary>
        /// 
        /// </summary>
        Requeue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequeueRejectedTasksModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequeueRejectedTasksModeEnum value)
        {
            return value switch
            {
                RequeueRejectedTasksModeEnum.Flexible => "flexible",
                RequeueRejectedTasksModeEnum.Remove => "remove",
                RequeueRejectedTasksModeEnum.Requeue => "requeue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequeueRejectedTasksModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "flexible" => RequeueRejectedTasksModeEnum.Flexible,
                "remove" => RequeueRejectedTasksModeEnum.Remove,
                "requeue" => RequeueRejectedTasksModeEnum.Requeue,
                _ => null,
            };
        }
    }
}