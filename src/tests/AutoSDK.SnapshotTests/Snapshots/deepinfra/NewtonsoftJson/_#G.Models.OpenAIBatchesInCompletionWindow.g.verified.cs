//HintName: G.Models.OpenAIBatchesInCompletionWindow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The time frame within which the batch should be processed. Currently only 24h is supported.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIBatchesInCompletionWindow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="24h")]
        x24h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIBatchesInCompletionWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIBatchesInCompletionWindow value)
        {
            return value switch
            {
                OpenAIBatchesInCompletionWindow.x24h => "24h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIBatchesInCompletionWindow? ToEnum(string value)
        {
            return value switch
            {
                "24h" => OpenAIBatchesInCompletionWindow.x24h,
                _ => null,
            };
        }
    }
}