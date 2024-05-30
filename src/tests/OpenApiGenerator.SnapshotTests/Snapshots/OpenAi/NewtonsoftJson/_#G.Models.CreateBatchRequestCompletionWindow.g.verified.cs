//HintName: G.Models.CreateBatchRequestCompletionWindow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The time frame within which the batch should be processed. Currently only `24h` is supported.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateBatchRequestCompletionWindow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="24h")]
        _24h,
    }

    public static class CreateBatchRequestCompletionWindowExtensions
    {
        public static string ToValueString(this CreateBatchRequestCompletionWindow value)
        {
            return value switch
            {
                CreateBatchRequestCompletionWindow._24h => "24h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateBatchRequestCompletionWindow ToEnum(string value)
        {
            return value switch
            {
                "24h" => CreateBatchRequestCompletionWindow._24h,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateBatchRequestCompletionWindow ToEnum(int value)
        {
            return value switch
            {
                0 => CreateBatchRequestCompletionWindow._24h,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}