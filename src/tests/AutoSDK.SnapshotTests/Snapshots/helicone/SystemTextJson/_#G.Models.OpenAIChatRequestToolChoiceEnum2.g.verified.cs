//HintName: G.Models.OpenAIChatRequestToolChoiceEnum2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAIChatRequestToolChoiceEnum2
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
    public static class OpenAIChatRequestToolChoiceEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIChatRequestToolChoiceEnum2 value)
        {
            return value switch
            {
                OpenAIChatRequestToolChoiceEnum2.Auto => "auto",
                OpenAIChatRequestToolChoiceEnum2.None => "none",
                OpenAIChatRequestToolChoiceEnum2.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIChatRequestToolChoiceEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => OpenAIChatRequestToolChoiceEnum2.Auto,
                "none" => OpenAIChatRequestToolChoiceEnum2.None,
                "required" => OpenAIChatRequestToolChoiceEnum2.Required,
                _ => null,
            };
        }
    }
}