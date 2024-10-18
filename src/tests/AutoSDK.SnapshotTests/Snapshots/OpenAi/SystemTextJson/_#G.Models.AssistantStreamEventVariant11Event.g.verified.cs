//HintName: G.Models.AssistantStreamEventVariant11Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant11Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunCancelling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant11EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant11Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant11Event.ThreadRunCancelling => "thread.run.cancelling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant11Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.cancelling" => AssistantStreamEventVariant11Event.ThreadRunCancelling,
                _ => null,
            };
        }
    }
}