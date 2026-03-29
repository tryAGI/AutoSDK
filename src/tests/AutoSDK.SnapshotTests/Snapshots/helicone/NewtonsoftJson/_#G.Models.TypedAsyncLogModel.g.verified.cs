//HintName: G.Models.TypedAsyncLogModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TypedAsyncLogModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerRequest", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TypedProviderRequest ProviderRequest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerResponse", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TypedProviderResponse ProviderResponse { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timing")]
        public global::G.TypedTiming? Timing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.Provider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedAsyncLogModel" /> class.
        /// </summary>
        /// <param name="providerRequest"></param>
        /// <param name="providerResponse"></param>
        /// <param name="timing"></param>
        /// <param name="provider"></param>
        public TypedAsyncLogModel(
            global::G.TypedProviderRequest providerRequest,
            global::G.TypedProviderResponse providerResponse,
            global::G.TypedTiming? timing,
            global::G.Provider? provider)
        {
            this.ProviderRequest = providerRequest ?? throw new global::System.ArgumentNullException(nameof(providerRequest));
            this.ProviderResponse = providerResponse ?? throw new global::System.ArgumentNullException(nameof(providerResponse));
            this.Timing = timing;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedAsyncLogModel" /> class.
        /// </summary>
        public TypedAsyncLogModel()
        {
        }
    }
}