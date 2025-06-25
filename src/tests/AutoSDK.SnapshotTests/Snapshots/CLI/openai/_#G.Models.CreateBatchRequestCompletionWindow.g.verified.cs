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
        x24h,
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
                CreateBatchRequestCompletionWindow.x24h => "24h",
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
                "24h" => CreateBatchRequestCompletionWindow.x24h,
                _ => null,
            };
        }
    }
}