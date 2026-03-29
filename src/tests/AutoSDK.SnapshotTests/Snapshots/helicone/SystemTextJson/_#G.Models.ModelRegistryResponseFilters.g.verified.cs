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
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ModelCapability> Capabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Authors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ModelRegistryResponseFiltersProvider> Providers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRegistryResponseFilters" /> class.
        /// </summary>
        /// <param name="capabilities"></param>
        /// <param name="authors"></param>
        /// <param name="providers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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