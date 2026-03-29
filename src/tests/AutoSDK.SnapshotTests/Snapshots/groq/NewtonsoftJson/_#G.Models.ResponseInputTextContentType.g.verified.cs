//HintName: G.Models.ResponseInputTextContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the input item. Always `input_text`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseInputTextContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_text")]
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseInputTextContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInputTextContentType value)
        {
            return value switch
            {
                ResponseInputTextContentType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInputTextContentType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => ResponseInputTextContentType.InputText,
                _ => null,
            };
        }
    }
}