//HintName: G.Models.UpdateConduitShardsRequestShardsTransportMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport method. Possible values are:  
    ///   
    /// * webhook
    /// * websocket
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateConduitShardsRequestShardsTransportMethod
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
    }
}