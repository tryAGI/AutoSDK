//HintName: G.Models.UpdateNamespaceConnectionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateNamespaceConnectionResponse contains the updated connection.
    /// </summary>
    public sealed partial class UpdateNamespaceConnectionResponse
    {
        /// <summary>
        /// The created connection.<br/>
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
        /// Initializes a new instance of the <see cref="UpdateNamespaceConnectionResponse" /> class.
        /// </summary>
        /// <param name="connection">
        /// The created connection.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateNamespaceConnectionResponse(
            global::G.Connection? connection)
        {
            this.Connection = connection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNamespaceConnectionResponse" /> class.
        /// </summary>
        public UpdateNamespaceConnectionResponse()
        {
        }
    }
}