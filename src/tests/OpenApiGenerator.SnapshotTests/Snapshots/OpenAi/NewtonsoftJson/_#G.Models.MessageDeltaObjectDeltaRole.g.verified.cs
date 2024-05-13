//HintName: G.Models.MessageDeltaObjectDeltaRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The entity that produced the message. One of `user` or `assistant`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageDeltaObjectDeltaRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
    }
}