//HintName: G.Models.PromptEntityMetadataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The prompt template type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptEntityMetadataType
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
    public static class PromptEntityMetadataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptEntityMetadataType value)
        {
            return value switch
            {
                PromptEntityMetadataType.Chat => "chat",
                PromptEntityMetadataType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptEntityMetadataType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptEntityMetadataType.Chat,
                "completion" => PromptEntityMetadataType.Completion,
                _ => null,
            };
        }
    }
}