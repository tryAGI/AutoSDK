//HintName: G.Models.ListAppClientsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of OAuth application clients.
    /// </summary>
    public sealed partial class ListAppClientsResponse
    {
        /// <summary>
        /// List of App Clients.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_clients")]
        public global::System.Collections.Generic.IList<global::G.AppClient>? AppClients { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAppClientsResponse" /> class.
        /// </summary>
        /// <param name="appClients">
        /// List of App Clients.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.
        /// </param>
        public ListAppClientsResponse(
            global::System.Collections.Generic.IList<global::G.AppClient>? appClients,
            global::G.ListMetadata? metadata)
        {
            this.AppClients = appClients;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAppClientsResponse" /> class.
        /// </summary>
        public ListAppClientsResponse()
        {
        }
    }
}