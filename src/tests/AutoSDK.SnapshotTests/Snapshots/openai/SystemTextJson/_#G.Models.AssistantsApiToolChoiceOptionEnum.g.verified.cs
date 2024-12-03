//HintName: G.Models.AssistantsApiToolChoiceOptionEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call any tools and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools before responding to the user.
    /// </summary>
    public enum AssistantsApiToolChoiceOptionEnum
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
    public static class AssistantsApiToolChoiceOptionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantsApiToolChoiceOptionEnum value)
        {
            return value switch
            {
                AssistantsApiToolChoiceOptionEnum.None => "none",
                AssistantsApiToolChoiceOptionEnum.Auto => "auto",
                AssistantsApiToolChoiceOptionEnum.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantsApiToolChoiceOptionEnum? ToEnum(string value)
        {
            return value switch
            {
                "none" => AssistantsApiToolChoiceOptionEnum.None,
                "auto" => AssistantsApiToolChoiceOptionEnum.Auto,
                "required" => AssistantsApiToolChoiceOptionEnum.Required,
                _ => null,
            };
        }
    }
}