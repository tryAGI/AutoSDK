//HintName: G.Models.ResponseType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseType2
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseType2 value)
        {
            return value switch
            {
                ResponseType2.ContentArray => "contentArray",
                ResponseType2.File => "file",
                ResponseType2.Function => "function",
                ResponseType2.FunctionCall => "functionCall",
                ResponseType2.Image => "image",
                ResponseType2.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseType2? ToEnum(string value)
        {
            return value switch
            {
                "contentArray" => ResponseType2.ContentArray,
                "file" => ResponseType2.File,
                "function" => ResponseType2.Function,
                "functionCall" => ResponseType2.FunctionCall,
                "image" => ResponseType2.Image,
                "text" => ResponseType2.Text,
                _ => null,
            };
        }
    }
}