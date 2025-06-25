//HintName: G.Models.RealtimeResponseCreateParamsConversation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeResponseCreateParamsConversation
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseCreateParamsConversationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreateParamsConversation value)
        {
            return value switch
            {
                RealtimeResponseCreateParamsConversation.Auto => "auto",
                RealtimeResponseCreateParamsConversation.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCreateParamsConversation? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeResponseCreateParamsConversation.Auto,
                "none" => RealtimeResponseCreateParamsConversation.None,
                _ => null,
            };
        }
    }
}