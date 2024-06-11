//HintName: G.Models.AssistantsApiToolChoiceOptionVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call any tools and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools before responding to the user.
    /// </summary>
    public enum AssistantsApiToolChoiceOptionVariant1
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
    public static class AssistantsApiToolChoiceOptionVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantsApiToolChoiceOptionVariant1 value)
        {
            return value switch
            {
                AssistantsApiToolChoiceOptionVariant1.None => "none",
                AssistantsApiToolChoiceOptionVariant1.Auto => "auto",
                AssistantsApiToolChoiceOptionVariant1.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantsApiToolChoiceOptionVariant1? ToEnum(string value)
        {
            return value switch
            {
                "none" => AssistantsApiToolChoiceOptionVariant1.None,
                "auto" => AssistantsApiToolChoiceOptionVariant1.Auto,
                "required" => AssistantsApiToolChoiceOptionVariant1.Required,
                _ => null,
            };
        }
    }
}