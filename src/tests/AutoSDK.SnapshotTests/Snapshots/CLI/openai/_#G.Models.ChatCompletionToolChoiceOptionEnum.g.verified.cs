//HintName: G.Models.ChatCompletionToolChoiceOptionEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call any tool and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools.
    /// </summary>
    public enum ChatCompletionToolChoiceOptionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionToolChoiceOptionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionToolChoiceOptionEnum value)
        {
            return value switch
            {
                ChatCompletionToolChoiceOptionEnum.None => "none",
                ChatCompletionToolChoiceOptionEnum.Auto => "auto",
                ChatCompletionToolChoiceOptionEnum.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionToolChoiceOptionEnum? ToEnum(string value)
        {
            return value switch
            {
                "none" => ChatCompletionToolChoiceOptionEnum.None,
                "auto" => ChatCompletionToolChoiceOptionEnum.Auto,
                "required" => ChatCompletionToolChoiceOptionEnum.Required,
                _ => null,
            };
        }
    }
}