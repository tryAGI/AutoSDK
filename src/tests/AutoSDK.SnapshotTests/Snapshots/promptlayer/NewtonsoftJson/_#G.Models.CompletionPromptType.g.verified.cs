//HintName: G.Models.CompletionPromptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: completion
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompletionPromptType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completion")]
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionPromptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionPromptType value)
        {
            return value switch
            {
                CompletionPromptType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionPromptType? ToEnum(string value)
        {
            return value switch
            {
                "completion" => CompletionPromptType.Completion,
                _ => null,
            };
        }
    }
}