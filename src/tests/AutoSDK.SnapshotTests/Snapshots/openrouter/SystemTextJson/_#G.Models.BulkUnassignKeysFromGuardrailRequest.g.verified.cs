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
        [global::System.Text.Json.Serialization.JsonPropertyName("key_hashes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> KeyHashes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUnassignKeysFromGuardrailRequest" /> class.
        /// </summary>
        /// <param name="keyHashes">
        /// Array of API key hashes to unassign from the guardrail
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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