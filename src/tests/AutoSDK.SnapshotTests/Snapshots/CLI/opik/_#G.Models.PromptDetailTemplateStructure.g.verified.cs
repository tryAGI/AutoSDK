//HintName: G.Models.PromptDetailTemplateStructure.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Template structure type: 'text' or 'chat'. Immutable after creation.<br/>
    /// Default Value: text
    /// </summary>
    public enum PromptDetailTemplateStructure
    {
        /// <summary>
        /// 'text' or 'chat'. Immutable after creation.
        /// </summary>
        Chat,
        /// <summary>
        /// 'text' or 'chat'. Immutable after creation.
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptDetailTemplateStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptDetailTemplateStructure value)
        {
            return value switch
            {
                PromptDetailTemplateStructure.Chat => "chat",
                PromptDetailTemplateStructure.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptDetailTemplateStructure? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptDetailTemplateStructure.Chat,
                "text" => PromptDetailTemplateStructure.Text,
                _ => null,
            };
        }
    }
}