//HintName: G.Models.ApiKeysGetCurrentKeyResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeysGetCurrentKeyResponse200
    {
        /// <summary>
        /// Current API key information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.KeyGetResponsesContentApplicationJsonSchemaData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysGetCurrentKeyResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// Current API key information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeysGetCurrentKeyResponse200(
            global::G.KeyGetResponsesContentApplicationJsonSchemaData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysGetCurrentKeyResponse200" /> class.
        /// </summary>
        public ApiKeysGetCurrentKeyResponse200()
        {
        }
    }
}