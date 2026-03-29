//HintName: G.Models.GetPromptTemplateResponsePromptTemplateDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPromptTemplateResponsePromptTemplateDiscriminatorType
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
    public static class GetPromptTemplateResponsePromptTemplateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPromptTemplateResponsePromptTemplateDiscriminatorType value)
        {
            return value switch
            {
                GetPromptTemplateResponsePromptTemplateDiscriminatorType.Chat => "chat",
                GetPromptTemplateResponsePromptTemplateDiscriminatorType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPromptTemplateResponsePromptTemplateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => GetPromptTemplateResponsePromptTemplateDiscriminatorType.Chat,
                "completion" => GetPromptTemplateResponsePromptTemplateDiscriminatorType.Completion,
                _ => null,
            };
        }
    }
}