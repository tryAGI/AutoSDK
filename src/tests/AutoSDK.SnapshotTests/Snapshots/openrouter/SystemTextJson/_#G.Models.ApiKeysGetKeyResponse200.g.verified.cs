//HintName: G.Models.ApiKeysGetKeyResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeysGetKeyResponse200
    {
        /// <summary>
        /// The API key information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.KeysHashGetResponsesContentApplicationJsonSchemaData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysGetKeyResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// The API key information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeysGetKeyResponse200(
            global::G.KeysHashGetResponsesContentApplicationJsonSchemaData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysGetKeyResponse200" /> class.
        /// </summary>
        public ApiKeysGetKeyResponse200()
        {
        }
    }
}