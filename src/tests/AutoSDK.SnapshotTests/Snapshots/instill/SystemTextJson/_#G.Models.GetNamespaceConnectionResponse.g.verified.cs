//HintName: G.Models.GetNamespaceConnectionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetNamespaceConnectionResponse contains the requested connection.
    /// </summary>
    public sealed partial class GetNamespaceConnectionResponse
    {
        /// <summary>
        /// The requested connection.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection")]
        public global::G.Connection? Connection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespaceConnectionResponse" /> class.
        /// </summary>
        /// <param name="connection">
        /// The requested connection.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetNamespaceConnectionResponse(
            global::G.Connection? connection)
        {
            this.Connection = connection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespaceConnectionResponse" /> class.
        /// </summary>
        public GetNamespaceConnectionResponse()
        {
        }
    }
}