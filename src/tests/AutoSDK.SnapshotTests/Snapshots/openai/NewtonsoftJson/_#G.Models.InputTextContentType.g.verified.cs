//HintName: G.Models.InputTextContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the input item. Always `input_text`.<br/>
    /// Default Value: input_text
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputTextContentType
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
    public static class InputTextContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputTextContentType value)
        {
            return value switch
            {
                InputTextContentType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputTextContentType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => InputTextContentType.InputText,
                _ => null,
            };
        }
    }
}