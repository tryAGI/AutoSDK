//HintName: G.Models.BulkAssignKeysToGuardrailRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkAssignKeysToGuardrailRequest
    {
        /// <summary>
        /// Array of API key hashes to assign to the guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_hashes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> KeyHashes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAssignKeysToGuardrailRequest" /> class.
        /// </summary>
        /// <param name="keyHashes">
        /// Array of API key hashes to assign to the guardrail
        /// </param>
        public BulkAssignKeysToGuardrailRequest(
            global::System.Collections.Generic.IList<string> keyHashes)
        {
            this.KeyHashes = keyHashes ?? throw new global::System.ArgumentNullException(nameof(keyHashes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAssignKeysToGuardrailRequest" /> class.
        /// </summary>
        public BulkAssignKeysToGuardrailRequest()
        {
        }
    }
}