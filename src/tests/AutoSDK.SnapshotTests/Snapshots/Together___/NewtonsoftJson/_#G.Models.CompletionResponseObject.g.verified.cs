//HintName: G.Models.CompletionResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompletionResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_completion")]
        TextCompletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionResponseObject value)
        {
            return value switch
            {
                CompletionResponseObject.TextCompletion => "text_completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "text_completion" => CompletionResponseObject.TextCompletion,
                _ => null,
            };
        }
    }
}