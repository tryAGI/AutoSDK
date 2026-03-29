//HintName: G.Models.PromptVersionTemplateStructure.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public enum PromptVersionTemplateStructure
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionTemplateStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionTemplateStructure value)
        {
            return value switch
            {
                PromptVersionTemplateStructure.Chat => "chat",
                PromptVersionTemplateStructure.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionTemplateStructure? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptVersionTemplateStructure.Chat,
                "text" => PromptVersionTemplateStructure.Text,
                _ => null,
            };
        }
    }
}