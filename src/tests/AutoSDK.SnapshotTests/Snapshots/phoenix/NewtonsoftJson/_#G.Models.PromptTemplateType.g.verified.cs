//HintName: G.Models.PromptTemplateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptTemplateType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHAT")]
        Chat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STR")]
        Str,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptTemplateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptTemplateType value)
        {
            return value switch
            {
                PromptTemplateType.Chat => "CHAT",
                PromptTemplateType.Str => "STR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptTemplateType? ToEnum(string value)
        {
            return value switch
            {
                "CHAT" => PromptTemplateType.Chat,
                "STR" => PromptTemplateType.Str,
                _ => null,
            };
        }
    }
}