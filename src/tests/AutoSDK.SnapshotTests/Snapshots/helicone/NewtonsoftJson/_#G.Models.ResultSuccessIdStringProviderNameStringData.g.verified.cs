//HintName: G.Models.ResultSuccessIdStringProviderNameStringData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessIdStringProviderNameStringData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessIdStringProviderNameStringData" /> class.
        /// </summary>
        /// <param name="providerName"></param>
        /// <param name="id"></param>
        public ResultSuccessIdStringProviderNameStringData(
            string providerName,
            string id)
        {
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessIdStringProviderNameStringData" /> class.
        /// </summary>
        public ResultSuccessIdStringProviderNameStringData()
        {
        }
    }
}