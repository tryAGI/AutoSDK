//HintName: G.Models.PromptBlockDataNullishCompletionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptBlockDataNullishCompletionType
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
    public static class PromptBlockDataNullishCompletionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockDataNullishCompletionType value)
        {
            return value switch
            {
                PromptBlockDataNullishCompletionType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockDataNullishCompletionType? ToEnum(string value)
        {
            return value switch
            {
                "completion" => PromptBlockDataNullishCompletionType.Completion,
                _ => null,
            };
        }
    }
}