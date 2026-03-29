//HintName: G.Models.PromptVersionPublicTemplateStructure.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptVersionPublicTemplateStructure
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat")]
        Chat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionPublicTemplateStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionPublicTemplateStructure value)
        {
            return value switch
            {
                PromptVersionPublicTemplateStructure.Chat => "chat",
                PromptVersionPublicTemplateStructure.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionPublicTemplateStructure? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptVersionPublicTemplateStructure.Chat,
                "text" => PromptVersionPublicTemplateStructure.Text,
                _ => null,
            };
        }
    }
}