//HintName: G.Models.GenerateCompletionRequestFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format to return a response in. Currently the only accepted value is json.
    /// Enable JSON mode by setting the format parameter to json. This will structure the response as valid JSON.
    /// Note: it's important to instruct the model to use JSON in the prompt. Otherwise, the model may generate large amounts whitespace.
    /// </summary>
    public enum GenerateCompletionRequestFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    public static class GenerateCompletionRequestFormatExtensions
    {
        public static string ToValueString(this GenerateCompletionRequestFormat value)
        {
            return value switch
            {
                GenerateCompletionRequestFormat.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GenerateCompletionRequestFormat ToEnum(string value)
        {
            return value switch
            {
                "json" => GenerateCompletionRequestFormat.Json,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GenerateCompletionRequestFormat ToEnum(int value)
        {
            return value switch
            {
                0 => GenerateCompletionRequestFormat.Json,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}