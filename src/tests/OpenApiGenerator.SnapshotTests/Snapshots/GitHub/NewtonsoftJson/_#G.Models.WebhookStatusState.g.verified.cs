//HintName: G.Models.WebhookStatusState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The new state. Can be `pending`, `success`, `failure`, or `error`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookStatusState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }
}