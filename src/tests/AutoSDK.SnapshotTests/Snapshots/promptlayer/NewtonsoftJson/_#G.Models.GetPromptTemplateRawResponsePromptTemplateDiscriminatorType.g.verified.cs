//HintName: G.Models.GetPromptTemplateRawResponsePromptTemplateDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPromptTemplateRawResponsePromptTemplateDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat")]
        Chat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completion")]
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPromptTemplateRawResponsePromptTemplateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPromptTemplateRawResponsePromptTemplateDiscriminatorType value)
        {
            return value switch
            {
                GetPromptTemplateRawResponsePromptTemplateDiscriminatorType.Chat => "chat",
                GetPromptTemplateRawResponsePromptTemplateDiscriminatorType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPromptTemplateRawResponsePromptTemplateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => GetPromptTemplateRawResponsePromptTemplateDiscriminatorType.Chat,
                "completion" => GetPromptTemplateRawResponsePromptTemplateDiscriminatorType.Completion,
                _ => null,
            };
        }
    }
}