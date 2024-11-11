//HintName: G.Models.GetIntegrationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetIntegrationResponse contains the requested integration.
    /// </summary>
    public sealed partial class GetIntegrationResponse
    {
        /// <summary>
        /// The requested integration.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration")]
        public global::G.Integration? Integration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResponse" /> class.
        /// </summary>
        /// <param name="integration">
        /// The requested integration.<br/>
        /// Included only in responses
        /// </param>
        public GetIntegrationResponse(
            global::G.Integration? integration)
        {
            this.Integration = integration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResponse" /> class.
        /// </summary>
        public GetIntegrationResponse()
        {
        }
    }
}