//HintName: G.Models.ResponseToolChoiceOptionEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call any tool and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools.
    /// </summary>
    public enum ResponseToolChoiceOptionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseToolChoiceOptionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseToolChoiceOptionEnum value)
        {
            return value switch
            {
                ResponseToolChoiceOptionEnum.Auto => "auto",
                ResponseToolChoiceOptionEnum.None => "none",
                ResponseToolChoiceOptionEnum.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseToolChoiceOptionEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseToolChoiceOptionEnum.Auto,
                "none" => ResponseToolChoiceOptionEnum.None,
                "required" => ResponseToolChoiceOptionEnum.Required,
                _ => null,
            };
        }
    }
}