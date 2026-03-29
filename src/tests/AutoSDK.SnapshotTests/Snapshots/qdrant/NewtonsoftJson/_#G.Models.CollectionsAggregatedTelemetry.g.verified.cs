//HintName: G.Models.CollectionsAggregatedTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionsAggregatedTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vectors", Required = global::Newtonsoft.Json.Required.Always)]
        public int Vectors { get; set; } = default!;

        /// <summary>
        /// Current state of the collection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimizers_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OptimizersStatus OptimizersStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CollectionParams Params { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsAggregatedTelemetry" /> class.
        /// </summary>
        /// <param name="vectors"></param>
        /// <param name="optimizersStatus">
        /// Current state of the collection
        /// </param>
        /// <param name="params"></param>
        public CollectionsAggregatedTelemetry(
            int vectors,
            global::G.OptimizersStatus optimizersStatus,
            global::G.CollectionParams @params)
        {
            this.Vectors = vectors;
            this.OptimizersStatus = optimizersStatus;
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsAggregatedTelemetry" /> class.
        /// </summary>
        public CollectionsAggregatedTelemetry()
        {
        }
    }
}