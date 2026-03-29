//HintName: G.Models.PromptPublicTemplateStructure.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Template structure type: 'text' or 'chat'. Immutable after creation.<br/>
    /// Default Value: text
    /// </summary>
    public enum PromptPublicTemplateStructure
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
    public static class PromptPublicTemplateStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptPublicTemplateStructure value)
        {
            return value switch
            {
                PromptPublicTemplateStructure.Chat => "chat",
                PromptPublicTemplateStructure.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptPublicTemplateStructure? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptPublicTemplateStructure.Chat,
                "text" => PromptPublicTemplateStructure.Text,
                _ => null,
            };
        }
    }
}