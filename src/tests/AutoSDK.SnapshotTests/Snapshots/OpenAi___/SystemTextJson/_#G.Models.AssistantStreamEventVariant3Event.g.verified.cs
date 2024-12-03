//HintName: G.Models.AssistantStreamEventVariant3Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant3Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant3EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant3Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant3Event.ThreadCreated => "thread.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant3Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.created" => AssistantStreamEventVariant3Event.ThreadCreated,
                _ => null,
            };
        }
    }
}