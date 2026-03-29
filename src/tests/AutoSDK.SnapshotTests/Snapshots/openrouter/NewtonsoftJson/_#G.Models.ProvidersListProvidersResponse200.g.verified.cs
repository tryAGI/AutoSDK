//HintName: G.Models.ProvidersListProvidersResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProvidersListProvidersResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItems> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvidersListProvidersResponse200" /> class.
        /// </summary>
        /// <param name="data"></param>
        public ProvidersListProvidersResponse200(
            global::System.Collections.Generic.IList<global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItems> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvidersListProvidersResponse200" /> class.
        /// </summary>
        public ProvidersListProvidersResponse200()
        {
        }
    }
}