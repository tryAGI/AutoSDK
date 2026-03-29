//HintName: G.Models.MessageStreamEventVariant4Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageStreamEventVariant4Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.completed")]
        ThreadMessageCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageStreamEventVariant4EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStreamEventVariant4Event value)
        {
            return value switch
            {
                MessageStreamEventVariant4Event.ThreadMessageCompleted => "thread.message.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStreamEventVariant4Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.completed" => MessageStreamEventVariant4Event.ThreadMessageCompleted,
                _ => null,
            };
        }
    }
}