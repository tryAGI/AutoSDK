//HintName: G.Models.AssistantStreamEventVariant21Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant21Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadMessageCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant21EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant21Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant21Event.ThreadMessageCreated => "thread.message.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant21Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.created" => AssistantStreamEventVariant21Event.ThreadMessageCreated,
                _ => null,
            };
        }
    }
}