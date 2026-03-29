//HintName: G.Models.PromptBlueprintPromptTemplateDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptBlueprintPromptTemplateDiscriminatorType
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
    public static class PromptBlueprintPromptTemplateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlueprintPromptTemplateDiscriminatorType value)
        {
            return value switch
            {
                PromptBlueprintPromptTemplateDiscriminatorType.Chat => "chat",
                PromptBlueprintPromptTemplateDiscriminatorType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlueprintPromptTemplateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptBlueprintPromptTemplateDiscriminatorType.Chat,
                "completion" => PromptBlueprintPromptTemplateDiscriminatorType.Completion,
                _ => null,
            };
        }
    }
}