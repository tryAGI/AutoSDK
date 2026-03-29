//HintName: G.Models.ChatAccepts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatAccepts
    {
        /// <summary>
        /// 
        /// </summary>
        TextEventStream,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatAcceptsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatAccepts value)
        {
            return value switch
            {
                ChatAccepts.TextEventStream => "text/event-stream",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatAccepts? ToEnum(string value)
        {
            return value switch
            {
                "text/event-stream" => ChatAccepts.TextEventStream,
                _ => null,
            };
        }
    }
}