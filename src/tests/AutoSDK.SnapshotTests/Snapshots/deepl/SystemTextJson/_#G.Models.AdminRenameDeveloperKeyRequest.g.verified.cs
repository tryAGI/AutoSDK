//HintName: G.Models.AdminRenameDeveloperKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminRenameDeveloperKeyRequest
    {
        /// <summary>
        /// API key ID. Consists of two valid GUIDs separated by a colon.<br/>
        /// Example: ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38
        /// </summary>
        /// <example>ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// API key label.<br/>
        /// Example: developer key prod
        /// </summary>
        /// <example>developer key prod</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminRenameDeveloperKeyRequest" /> class.
        /// </summary>
        /// <param name="keyId">
        /// API key ID. Consists of two valid GUIDs separated by a colon.<br/>
        /// Example: ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38
        /// </param>
        /// <param name="label">
        /// API key label.<br/>
        /// Example: developer key prod
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminRenameDeveloperKeyRequest(
            string keyId,
            string label)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminRenameDeveloperKeyRequest" /> class.
        /// </summary>
        public AdminRenameDeveloperKeyRequest()
        {
        }
    }
}