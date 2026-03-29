//HintName: G.Models.MessageType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="autoInput")]
        AutoInput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contentArray")]
        ContentArray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="functionCall")]
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message")]
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