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
        [global::Newtonsoft.Json.JsonProperty("passages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PassageCreateRequest> Passages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PassageBatchCreateRequest" /> class.
        /// </summary>
        /// <param name="passages">
        /// Passages to create in the archive
        /// </param>
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