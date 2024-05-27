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
}