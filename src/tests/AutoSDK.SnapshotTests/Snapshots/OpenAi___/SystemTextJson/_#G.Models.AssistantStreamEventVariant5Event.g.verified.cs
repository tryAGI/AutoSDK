//HintName: G.Models.AssistantStreamEventVariant5Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant5Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunQueued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant5EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant5Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant5Event.ThreadRunQueued => "thread.run.queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant5Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.queued" => AssistantStreamEventVariant5Event.ThreadRunQueued,
                _ => null,
            };
        }
    }
}