//HintName: G.Models.GetFederationResponseForConnectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFederationResponseForConnectionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectionKey", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ConnectionKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFederationResponseForConnectionRequest" /> class.
        /// </summary>
        /// <param name="connectionKey"></param>
        public GetFederationResponseForConnectionRequest(
            global::System.Guid connectionKey)
        {
            this.ConnectionKey = connectionKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFederationResponseForConnectionRequest" /> class.
        /// </summary>
        public GetFederationResponseForConnectionRequest()
        {
        }
    }
}