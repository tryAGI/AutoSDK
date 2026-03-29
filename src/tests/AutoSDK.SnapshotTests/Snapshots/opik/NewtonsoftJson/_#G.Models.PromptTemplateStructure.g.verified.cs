//HintName: G.Models.PromptTemplateStructure.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Template structure type: 'text' or 'chat'. Immutable after creation.<br/>
    /// Default Value: text
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptTemplateStructure
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
    public static class PromptTemplateStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptTemplateStructure value)
        {
            return value switch
            {
                PromptTemplateStructure.Chat => "chat",
                PromptTemplateStructure.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptTemplateStructure? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptTemplateStructure.Chat,
                "text" => PromptTemplateStructure.Text,
                _ => null,
            };
        }
    }
}