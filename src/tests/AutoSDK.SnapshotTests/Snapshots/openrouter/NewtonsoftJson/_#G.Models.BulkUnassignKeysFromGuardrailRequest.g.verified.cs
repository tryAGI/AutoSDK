//HintName: G.Models.BulkUnassignKeysFromGuardrailRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUnassignKeysFromGuardrailRequest
    {
        /// <summary>
        /// Array of API key hashes to unassign from the guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_hashes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> KeyHashes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUnassignKeysFromGuardrailRequest" /> class.
        /// </summary>
        /// <param name="keyHashes">
        /// Array of API key hashes to unassign from the guardrail
        /// </param>
        public BulkUnassignKeysFromGuardrailRequest(
            global::System.Collections.Generic.IList<string> keyHashes)
        {
            this.KeyHashes = keyHashes ?? throw new global::System.ArgumentNullException(nameof(keyHashes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUnassignKeysFromGuardrailRequest" /> class.
        /// </summary>
        public BulkUnassignKeysFromGuardrailRequest()
        {
        }
    }
}