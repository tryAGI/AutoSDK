//HintName: G.Models.GetPromptTemplateResponsePromptTemplateDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPromptTemplateResponsePromptTemplateDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPromptTemplateResponsePromptTemplateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPromptTemplateResponsePromptTemplateDiscriminatorType value)
        {
            return value switch
            {
                GetPromptTemplateResponsePromptTemplateDiscriminatorType.Chat => "chat",
                GetPromptTemplateResponsePromptTemplateDiscriminatorType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPromptTemplateResponsePromptTemplateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => GetPromptTemplateResponsePromptTemplateDiscriminatorType.Chat,
                "completion" => GetPromptTemplateResponsePromptTemplateDiscriminatorType.Completion,
                _ => null,
            };
        }
    }
}