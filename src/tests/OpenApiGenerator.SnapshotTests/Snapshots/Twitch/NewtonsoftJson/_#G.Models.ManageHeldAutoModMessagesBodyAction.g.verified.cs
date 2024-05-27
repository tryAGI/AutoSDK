//HintName: G.Models.ManageHeldAutoModMessagesBodyAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The action to take for the message. Possible values are:  
    ///   
    /// * ALLOW
    /// * DENY
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ManageHeldAutoModMessagesBodyAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ALLOW")]
        ALLOW,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DENY")]
        DENY,
    }
}