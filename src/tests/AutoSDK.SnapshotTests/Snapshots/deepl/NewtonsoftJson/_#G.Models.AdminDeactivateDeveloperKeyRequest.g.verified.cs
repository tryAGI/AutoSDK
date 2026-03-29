//HintName: G.Models.AdminDeactivateDeveloperKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminDeactivateDeveloperKeyRequest
    {
        /// <summary>
        /// API key ID. Consists of two valid GUIDs separated by a colon.<br/>
        /// Example: ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38
        /// </summary>
        /// <example>ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38</example>
        [global::Newtonsoft.Json.JsonProperty("key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminDeactivateDeveloperKeyRequest" /> class.
        /// </summary>
        /// <param name="keyId">
        /// API key ID. Consists of two valid GUIDs separated by a colon.<br/>
        /// Example: ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38
        /// </param>
        public AdminDeactivateDeveloperKeyRequest(
            string keyId)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminDeactivateDeveloperKeyRequest" /> class.
        /// </summary>
        public AdminDeactivateDeveloperKeyRequest()
        {
        }
    }
}