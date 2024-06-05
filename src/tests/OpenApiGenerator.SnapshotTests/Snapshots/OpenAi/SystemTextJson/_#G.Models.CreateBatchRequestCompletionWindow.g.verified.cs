//HintName: G.Models.CreateBatchRequestCompletionWindow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The time frame within which the batch should be processed. Currently only `24h` is supported.
    /// </summary>
    public enum CreateBatchRequestCompletionWindow
    {
        /// <summary>
        /// 
        /// </summary>
        _24h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBatchRequestCompletionWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBatchRequestCompletionWindow value)
        {
            return value switch
            {
                CreateBatchRequestCompletionWindow._24h => "24h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBatchRequestCompletionWindow? ToEnum(string value)
        {
            return value switch
            {
                "24h" => CreateBatchRequestCompletionWindow._24h,
                _ => null,
            };
        }
    }
}