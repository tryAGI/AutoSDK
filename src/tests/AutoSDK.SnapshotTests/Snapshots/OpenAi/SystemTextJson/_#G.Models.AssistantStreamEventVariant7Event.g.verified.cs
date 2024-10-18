//HintName: G.Models.AssistantStreamEventVariant7Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant7Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunRequiresAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant7EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant7Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant7Event.ThreadRunRequiresAction => "thread.run.requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant7Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.requires_action" => AssistantStreamEventVariant7Event.ThreadRunRequiresAction,
                _ => null,
            };
        }
    }
}