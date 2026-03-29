//HintName: G.Models.PassageBatchCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for creating multiple passages in an archive.
    /// </summary>
    public sealed partial class PassageBatchCreateRequest
    {
        /// <summary>
        /// Passages to create in the archive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PassageCreateRequest> Passages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PassageBatchCreateRequest" /> class.
        /// </summary>
        /// <param name="passages">
        /// Passages to create in the archive
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PassageBatchCreateRequest(
            global::System.Collections.Generic.IList<global::G.PassageCreateRequest> passages)
        {
            this.Passages = passages ?? throw new global::System.ArgumentNullException(nameof(passages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassageBatchCreateRequest" /> class.
        /// </summary>
        public PassageBatchCreateRequest()
        {
        }
    }
}