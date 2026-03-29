//HintName: G.Models.ApiKeyList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of API keys for a project
    /// </summary>
    public sealed partial class ApiKeyList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKeys", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ApiKeySummary> ApiKeys { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyList" /> class.
        /// </summary>
        /// <param name="apiKeys"></param>
        public ApiKeyList(
            global::System.Collections.Generic.IList<global::G.ApiKeySummary> apiKeys)
        {
            this.ApiKeys = apiKeys ?? throw new global::System.ArgumentNullException(nameof(apiKeys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyList" /> class.
        /// </summary>
        public ApiKeyList()
        {
        }
    }
}