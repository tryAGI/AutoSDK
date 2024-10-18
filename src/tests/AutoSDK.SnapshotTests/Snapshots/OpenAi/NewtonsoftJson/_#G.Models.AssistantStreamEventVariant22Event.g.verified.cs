//HintName: G.Models.AssistantStreamEventVariant22Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantStreamEventVariant22Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.in_progress")]
        ThreadMessageInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant22EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant22Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant22Event.ThreadMessageInProgress => "thread.message.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant22Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.in_progress" => AssistantStreamEventVariant22Event.ThreadMessageInProgress,
                _ => null,
            };
        }
    }
}