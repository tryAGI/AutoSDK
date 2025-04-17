//HintName: G.Models.CompletionFTModelOutModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: completion
    /// </summary>
    public enum CompletionFTModelOutModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionFTModelOutModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionFTModelOutModelType value)
        {
            return value switch
            {
                CompletionFTModelOutModelType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionFTModelOutModelType? ToEnum(string value)
        {
            return value switch
            {
                "completion" => CompletionFTModelOutModelType.Completion,
                _ => null,
            };
        }
    }
}