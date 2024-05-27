//HintName: G.Models.SendExtensionPubsubMessageRequestTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SendExtensionPubsubMessageRequestTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="broadcast")]
        Broadcast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="global")]
        Global,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="whisper-<user-id>")]
        Whisper_userId_,
    }
}