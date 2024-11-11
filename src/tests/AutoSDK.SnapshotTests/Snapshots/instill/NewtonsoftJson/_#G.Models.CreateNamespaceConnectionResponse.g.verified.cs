//HintName: G.Models.CreateNamespaceConnectionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CreateNamespaceConnectionResponse contains the created connection.
    /// </summary>
    public sealed partial class CreateNamespaceConnectionResponse
    {
        /// <summary>
        /// The created connection.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connection")]
        public global::G.Connection? Connection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespaceConnectionResponse" /> class.
        /// </summary>
        /// <param name="connection">
        /// The created connection.<br/>
        /// Included only in responses
        /// </param>
        public CreateNamespaceConnectionResponse(
            global::G.Connection? connection)
        {
            this.Connection = connection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespaceConnectionResponse" /> class.
        /// </summary>
        public CreateNamespaceConnectionResponse()
        {
        }
    }
}