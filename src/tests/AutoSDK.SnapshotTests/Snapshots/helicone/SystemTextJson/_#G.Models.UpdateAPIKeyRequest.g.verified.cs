//HintName: G.Models.UpdateAPIKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAPIKeyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAPIKeyRequest" /> class.
        /// </summary>
        /// <param name="apiKeyName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAPIKeyRequest(
            string apiKeyName)
        {
            this.ApiKeyName = apiKeyName ?? throw new global::System.ArgumentNullException(nameof(apiKeyName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAPIKeyRequest" /> class.
        /// </summary>
        public UpdateAPIKeyRequest()
        {
        }
    }
}