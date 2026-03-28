//HintName: G.Models.ChatAccepts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatAccepts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text/event-stream")]
        TextDivideeventStream,
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
                ChatAccepts.TextDivideeventStream => "text/event-stream",
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
                "text/event-stream" => ChatAccepts.TextDivideeventStream,
                _ => null,
            };
        }
    }
}