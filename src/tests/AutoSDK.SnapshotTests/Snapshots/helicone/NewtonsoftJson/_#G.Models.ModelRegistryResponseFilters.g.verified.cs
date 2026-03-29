//HintName: G.Models.ModelRegistryResponseFilters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelRegistryResponseFilters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("capabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelCapability> Capabilities { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Authors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelRegistryResponseFiltersProvider> Providers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRegistryResponseFilters" /> class.
        /// </summary>
        /// <param name="capabilities"></param>
        /// <param name="authors"></param>
        /// <param name="providers"></param>
        public ModelRegistryResponseFilters(
            global::System.Collections.Generic.IList<global::G.ModelCapability> capabilities,
            global::System.Collections.Generic.IList<string> authors,
            global::System.Collections.Generic.IList<global::G.ModelRegistryResponseFiltersProvider> providers)
        {
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.Authors = authors ?? throw new global::System.ArgumentNullException(nameof(authors));
            this.Providers = providers ?? throw new global::System.ArgumentNullException(nameof(providers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRegistryResponseFilters" /> class.
        /// </summary>
        public ModelRegistryResponseFilters()
        {
        }
    }
}