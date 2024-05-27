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
    public abstract class CreateEventsubSubscriptionRequestTransportMethod
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