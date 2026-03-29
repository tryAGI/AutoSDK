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
        [global::System.Text.Json.Serialization.JsonPropertyName("providerRequest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TypedProviderRequest ProviderRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerResponse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TypedProviderResponse ProviderResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timing")]
        public global::G.TypedTiming? Timing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProviderJsonConverter))]
        public global::G.Provider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedAsyncLogModel" /> class.
        /// </summary>
        /// <param name="providerRequest"></param>
        /// <param name="providerResponse"></param>
        /// <param name="timing"></param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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