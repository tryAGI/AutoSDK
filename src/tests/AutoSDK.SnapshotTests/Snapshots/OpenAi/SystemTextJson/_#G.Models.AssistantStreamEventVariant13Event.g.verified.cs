//HintName: G.Models.AssistantStreamEventVariant13Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant13Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant13EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant13Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant13Event.ThreadRunExpired => "thread.run.expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant13Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.expired" => AssistantStreamEventVariant13Event.ThreadRunExpired,
                _ => null,
            };
        }
    }
}