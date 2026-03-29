//HintName: G.Models.PromptToolsToolChoiceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptToolsToolChoiceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        OneOrMore,
        /// <summary>
        /// 
        /// </summary>
        SpecificFunction,
        /// <summary>
        /// 
        /// </summary>
        ZeroOrMore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptToolsToolChoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptToolsToolChoiceDiscriminatorType value)
        {
            return value switch
            {
                PromptToolsToolChoiceDiscriminatorType.None => "none",
                PromptToolsToolChoiceDiscriminatorType.OneOrMore => "one_or_more",
                PromptToolsToolChoiceDiscriminatorType.SpecificFunction => "specific_function",
                PromptToolsToolChoiceDiscriminatorType.ZeroOrMore => "zero_or_more",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptToolsToolChoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "none" => PromptToolsToolChoiceDiscriminatorType.None,
                "one_or_more" => PromptToolsToolChoiceDiscriminatorType.OneOrMore,
                "specific_function" => PromptToolsToolChoiceDiscriminatorType.SpecificFunction,
                "zero_or_more" => PromptToolsToolChoiceDiscriminatorType.ZeroOrMore,
                _ => null,
            };
        }
    }
}