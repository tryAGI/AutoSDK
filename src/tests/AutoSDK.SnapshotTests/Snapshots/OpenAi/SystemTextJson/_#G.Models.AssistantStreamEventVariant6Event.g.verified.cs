//HintName: G.Models.AssistantStreamEventVariant6Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant6Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant6EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant6Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant6Event.ThreadRunInProgress => "thread.run.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant6Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.in_progress" => AssistantStreamEventVariant6Event.ThreadRunInProgress,
                _ => null,
            };
        }
    }
}