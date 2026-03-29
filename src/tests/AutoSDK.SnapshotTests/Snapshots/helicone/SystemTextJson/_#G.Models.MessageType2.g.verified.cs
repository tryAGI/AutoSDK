//HintName: G.Models.MessageType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageType2
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        AutoInput,
        /// <summary>
        /// 
        /// </summary>
        ContentArray,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageType2 value)
        {
            return value switch
            {
                MessageType2.Audio => "audio",
                MessageType2.AutoInput => "autoInput",
                MessageType2.ContentArray => "contentArray",
                MessageType2.File => "file",
                MessageType2.Function => "function",
                MessageType2.FunctionCall => "functionCall",
                MessageType2.Image => "image",
                MessageType2.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageType2? ToEnum(string value)
        {
            return value switch
            {
                "audio" => MessageType2.Audio,
                "autoInput" => MessageType2.AutoInput,
                "contentArray" => MessageType2.ContentArray,
                "file" => MessageType2.File,
                "function" => MessageType2.Function,
                "functionCall" => MessageType2.FunctionCall,
                "image" => MessageType2.Image,
                "message" => MessageType2.Message,
                _ => null,
            };
        }
    }
}