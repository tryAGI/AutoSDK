//HintName: G.Models.PromptWriteTemplateStructure.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Template structure type: 'text' or 'chat'. Immutable after creation.<br/>
    /// Default Value: text
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptWriteTemplateStructure
    {
        /// <summary>
        /// 'text' or 'chat'. Immutable after creation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat")]
        Chat,
        /// <summary>
        /// 'text' or 'chat'. Immutable after creation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptWriteTemplateStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptWriteTemplateStructure value)
        {
            return value switch
            {
                PromptWriteTemplateStructure.Chat => "chat",
                PromptWriteTemplateStructure.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptWriteTemplateStructure? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptWriteTemplateStructure.Chat,
                "text" => PromptWriteTemplateStructure.Text,
                _ => null,
            };
        }
    }
}