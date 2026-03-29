//HintName: G.Models.PromptVersionTemplateDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptVersionTemplateDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionTemplateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionTemplateDiscriminatorType value)
        {
            return value switch
            {
                PromptVersionTemplateDiscriminatorType.Chat => "chat",
                PromptVersionTemplateDiscriminatorType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionTemplateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptVersionTemplateDiscriminatorType.Chat,
                "string" => PromptVersionTemplateDiscriminatorType.String,
                _ => null,
            };
        }
    }
}