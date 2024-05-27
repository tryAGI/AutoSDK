//HintName: G.Models.CreateEventSubSubscriptionBodyTransportMethod.g.cs

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
    public abstract class CreateEventSubSubscriptionBodyTransportMethod
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Webhook = "webhook";
        /// <summary>
        /// 
        /// </summary>
        public const string Websocket = "websocket";
        /// <summary>
        /// 
        /// </summary>
        public const string Conduit = "conduit";
    }
}