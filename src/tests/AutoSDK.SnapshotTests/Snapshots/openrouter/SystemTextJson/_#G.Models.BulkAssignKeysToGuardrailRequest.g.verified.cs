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
        [global::System.Text.Json.Serialization.JsonPropertyName("key_hashes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> KeyHashes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAssignKeysToGuardrailRequest" /> class.
        /// </summary>
        /// <param name="keyHashes">
        /// Array of API key hashes to assign to the guardrail
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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