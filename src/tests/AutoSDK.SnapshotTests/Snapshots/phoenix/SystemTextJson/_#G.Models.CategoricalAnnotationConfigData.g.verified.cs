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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"CATEGORICAL"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "CATEGORICAL";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimization_direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OptimizationDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OptimizationDirection OptimizationDirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CategoricalAnnotationValue> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalAnnotationConfigData" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="optimizationDirection"></param>
        /// <param name="values"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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