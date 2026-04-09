//HintName: G.Models.CategoricalAnnotationConfigData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoricalAnnotationConfigData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"CATEGORICAL"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "CATEGORICAL";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimization_direction", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OptimizationDirectionJsonConverter))]
        public global::G.OptimizationDirection OptimizationDirection { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CategoricalAnnotationValue> Values { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalAnnotationConfigData" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="optimizationDirection"></param>
        /// <param name="values"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        public CategoricalAnnotationConfigData(
            string name,
            global::G.OptimizationDirection optimizationDirection,
            global::System.Collections.Generic.IList<global::G.CategoricalAnnotationValue> values,
            string? description,
            string type = "CATEGORICAL")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description;
            this.OptimizationDirection = optimizationDirection;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalAnnotationConfigData" /> class.
        /// </summary>
        public CategoricalAnnotationConfigData()
        {
        }
    }
}