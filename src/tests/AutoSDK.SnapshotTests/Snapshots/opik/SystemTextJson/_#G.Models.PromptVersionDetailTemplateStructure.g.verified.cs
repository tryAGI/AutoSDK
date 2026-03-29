//HintName: G.Models.PromptVersionDetailTemplateStructure.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public enum PromptVersionDetailTemplateStructure
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
    public static class PromptVersionDetailTemplateStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionDetailTemplateStructure value)
        {
            return value switch
            {
                PromptVersionDetailTemplateStructure.Chat => "chat",
                PromptVersionDetailTemplateStructure.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionDetailTemplateStructure? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptVersionDetailTemplateStructure.Chat,
                "text" => PromptVersionDetailTemplateStructure.Text,
                _ => null,
            };
        }
    }
}