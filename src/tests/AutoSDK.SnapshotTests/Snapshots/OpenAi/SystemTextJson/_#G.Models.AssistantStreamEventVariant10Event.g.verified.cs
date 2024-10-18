//HintName: G.Models.AssistantStreamEventVariant10Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant10Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant10EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant10Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant10Event.ThreadRunFailed => "thread.run.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant10Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.failed" => AssistantStreamEventVariant10Event.ThreadRunFailed,
                _ => null,
            };
        }
    }
}