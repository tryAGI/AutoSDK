//HintName: G.Models.MessageObjectIncompleteDetailsReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the message is incomplete.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageObjectIncompleteDetailsReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_filter")]
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_tokens")]
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run_cancelled")]
        RunCancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run_expired")]
        RunExpired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run_failed")]
        RunFailed,
    }
}