//HintName: G.Models.AssistantStreamEventVariant25Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantStreamEventVariant25Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.incomplete")]
        ThreadMessageIncomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant25EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant25Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant25Event.ThreadMessageIncomplete => "thread.message.incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant25Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.incomplete" => AssistantStreamEventVariant25Event.ThreadMessageIncomplete,
                _ => null,
            };
        }
    }
}