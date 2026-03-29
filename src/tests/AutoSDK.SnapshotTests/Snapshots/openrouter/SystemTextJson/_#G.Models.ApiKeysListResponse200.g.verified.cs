//HintName: G.Models.ApiKeysListResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeysListResponse200
    {
        /// <summary>
        /// List of API keys
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.KeysGetResponsesContentApplicationJsonSchemaDataItems> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysListResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// List of API keys
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeysListResponse200(
            global::System.Collections.Generic.IList<global::G.KeysGetResponsesContentApplicationJsonSchemaDataItems> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysListResponse200" /> class.
        /// </summary>
        public ApiKeysListResponse200()
        {
        }
    }
}