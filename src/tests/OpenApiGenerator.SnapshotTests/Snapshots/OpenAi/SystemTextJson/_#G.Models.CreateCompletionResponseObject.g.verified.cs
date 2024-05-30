//HintName: G.Models.CreateCompletionResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "text_completion"
    /// </summary>
    public enum CreateCompletionResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        TextCompletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCompletionResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCompletionResponseObject value)
        {
            return value switch
            {
                CreateCompletionResponseObject.TextCompletion => "text_completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCompletionResponseObject ToEnum(string value)
        {
            return value switch
            {
                "text_completion" => CreateCompletionResponseObject.TextCompletion,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}