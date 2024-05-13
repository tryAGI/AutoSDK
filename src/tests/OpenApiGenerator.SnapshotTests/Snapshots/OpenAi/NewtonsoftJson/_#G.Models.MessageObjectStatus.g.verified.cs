//HintName: G.Models.MessageObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the message, which can be either `in_progress`, `incomplete`, or `completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="incomplete")]
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
    }
}