//HintName: G.Models.CheckNamespaceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CheckNamespaceRequest represents a request to verify if a namespace is<br/>
    /// available.
    /// </summary>
    public sealed partial class CheckNamespaceRequest
    {
        /// <summary>
        /// The namespace ID to be checked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckNamespaceRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// The namespace ID to be checked.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CheckNamespaceRequest(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckNamespaceRequest" /> class.
        /// </summary>
        public CheckNamespaceRequest()
        {
        }
    }
}