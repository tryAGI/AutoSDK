//HintName: G.Models.CreatePromptVersionDetailTemplateStructure.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Template structure for the prompt: 'text' or 'chat'. Note: This field is only used when creating a new prompt. If a prompt with the given name already exists, this field is ignored and the existing prompt's template structure is used. Template structure is immutable after prompt creation.<br/>
    /// Default Value: text
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreatePromptVersionDetailTemplateStructure
    {
        /// <summary>
        /// 'text' or 'chat'. Note: This field is only used when creating a new prompt. If a prompt with the given name already exists, this field is ignored and the existing prompt's template structure is used. Template structure is immutable after prompt creation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat")]
        Chat,
        /// <summary>
        /// 'text' or 'chat'. Note: This field is only used when creating a new prompt. If a prompt with the given name already exists, this field is ignored and the existing prompt's template structure is used. Template structure is immutable after prompt creation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePromptVersionDetailTemplateStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePromptVersionDetailTemplateStructure value)
        {
            return value switch
            {
                CreatePromptVersionDetailTemplateStructure.Chat => "chat",
                CreatePromptVersionDetailTemplateStructure.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePromptVersionDetailTemplateStructure? ToEnum(string value)
        {
            return value switch
            {
                "chat" => CreatePromptVersionDetailTemplateStructure.Chat,
                "text" => CreatePromptVersionDetailTemplateStructure.Text,
                _ => null,
            };
        }
    }
}