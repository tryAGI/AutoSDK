//HintName: G.Models.CompletionFTModelOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: model
    /// </summary>
    public enum CompletionFTModelOutObject
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionFTModelOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionFTModelOutObject value)
        {
            return value switch
            {
                CompletionFTModelOutObject.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionFTModelOutObject? ToEnum(string value)
        {
            return value switch
            {
                "model" => CompletionFTModelOutObject.Model,
                _ => null,
            };
        }
    }
}