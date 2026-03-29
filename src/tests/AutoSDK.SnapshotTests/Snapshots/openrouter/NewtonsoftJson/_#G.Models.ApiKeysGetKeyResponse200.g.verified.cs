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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.KeysHashGetResponsesContentApplicationJsonSchemaData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysGetKeyResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// The API key information
        /// </param>
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