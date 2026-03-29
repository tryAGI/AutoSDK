//HintName: G.Models.PostInternalTriggerLogsResponseDataItemMetaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Log entity type (trigger or action)<br/>
    /// Example: trigger
    /// </summary>
    public enum PostInternalTriggerLogsResponseDataItemMetaType
    {
        /// <summary>
        /// 
        /// </summary>
        Action,
        /// <summary>
        /// 
        /// </summary>
        Trigger,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostInternalTriggerLogsResponseDataItemMetaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostInternalTriggerLogsResponseDataItemMetaType value)
        {
            return value switch
            {
                PostInternalTriggerLogsResponseDataItemMetaType.Action => "action",
                PostInternalTriggerLogsResponseDataItemMetaType.Trigger => "trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostInternalTriggerLogsResponseDataItemMetaType? ToEnum(string value)
        {
            return value switch
            {
                "action" => PostInternalTriggerLogsResponseDataItemMetaType.Action,
                "trigger" => PostInternalTriggerLogsResponseDataItemMetaType.Trigger,
                _ => null,
            };
        }
    }
}