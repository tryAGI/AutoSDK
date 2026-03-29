//HintName: G.Models.PromptVersionDataTemplateDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptVersionDataTemplateDiscriminatorType
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
    public static class PromptVersionDataTemplateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionDataTemplateDiscriminatorType value)
        {
            return value switch
            {
                PromptVersionDataTemplateDiscriminatorType.Chat => "chat",
                PromptVersionDataTemplateDiscriminatorType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionDataTemplateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptVersionDataTemplateDiscriminatorType.Chat,
                "string" => PromptVersionDataTemplateDiscriminatorType.String,
                _ => null,
            };
        }
    }
}