//HintName: G.Models.GeneratedAssetDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedAssetDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GeneratedAssetDiscriminatorProviderJsonConverter))]
        public global::G.GeneratedAssetDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAssetDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
        public GeneratedAssetDiscriminator(
            global::G.GeneratedAssetDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAssetDiscriminator" /> class.
        /// </summary>
        public GeneratedAssetDiscriminator()
        {
        }
    }
}