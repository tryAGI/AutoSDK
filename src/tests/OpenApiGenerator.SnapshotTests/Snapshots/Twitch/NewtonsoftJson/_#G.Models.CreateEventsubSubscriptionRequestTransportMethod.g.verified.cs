//HintName: G.Models.CreateEventsubSubscriptionRequestTransportMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport method. Possible values are:  
    ///   
    /// * webhook
    /// * websocket
    /// * conduit
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEventsubSubscriptionRequestTransportMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket")]
        Websocket,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conduit")]
        Conduit,
    }
}