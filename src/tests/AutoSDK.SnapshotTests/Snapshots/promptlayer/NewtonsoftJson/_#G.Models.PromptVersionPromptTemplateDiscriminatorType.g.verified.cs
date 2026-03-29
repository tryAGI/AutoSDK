//HintName: G.Models.PromptVersionPromptTemplateDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptVersionPromptTemplateDiscriminatorType
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
    public static class PromptVersionPromptTemplateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionPromptTemplateDiscriminatorType value)
        {
            return value switch
            {
                PromptVersionPromptTemplateDiscriminatorType.Chat => "chat",
                PromptVersionPromptTemplateDiscriminatorType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionPromptTemplateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptVersionPromptTemplateDiscriminatorType.Chat,
                "completion" => PromptVersionPromptTemplateDiscriminatorType.Completion,
                _ => null,
            };
        }
    }
}