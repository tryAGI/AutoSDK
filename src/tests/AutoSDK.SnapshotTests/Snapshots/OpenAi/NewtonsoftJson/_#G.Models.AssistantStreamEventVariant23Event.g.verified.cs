//HintName: G.Models.AssistantStreamEventVariant23Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantStreamEventVariant23Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.delta")]
        ThreadMessageDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant23EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant23Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant23Event.ThreadMessageDelta => "thread.message.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant23Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.delta" => AssistantStreamEventVariant23Event.ThreadMessageDelta,
                _ => null,
            };
        }
    }
}