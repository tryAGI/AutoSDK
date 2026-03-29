//HintName: G.Models.ModelRegistryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelRegistryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelRegistryItem> Models { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public double Total { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelRegistryResponseFilters Filters { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRegistryResponse" /> class.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="total"></param>
        /// <param name="filters"></param>
        public ModelRegistryResponse(
            global::System.Collections.Generic.IList<global::G.ModelRegistryItem> models,
            double total,
            global::G.ModelRegistryResponseFilters filters)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.Total = total;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRegistryResponse" /> class.
        /// </summary>
        public ModelRegistryResponse()
        {
        }
    }
}