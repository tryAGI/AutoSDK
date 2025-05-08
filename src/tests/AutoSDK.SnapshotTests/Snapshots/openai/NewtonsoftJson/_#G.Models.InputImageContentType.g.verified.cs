//HintName: G.Models.InputImageContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the input item. Always `input_image`.<br/>
    /// Default Value: input_image
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputImageContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_image")]
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputImageContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputImageContentType value)
        {
            return value switch
            {
                InputImageContentType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputImageContentType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => InputImageContentType.InputImage,
                _ => null,
            };
        }
    }
}