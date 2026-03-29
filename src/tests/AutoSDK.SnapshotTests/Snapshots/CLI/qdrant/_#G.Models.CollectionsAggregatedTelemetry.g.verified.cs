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
        [global::System.Text.Json.Serialization.JsonPropertyName("vectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Vectors { get; set; }

        /// <summary>
        /// Current state of the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizers_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OptimizersStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OptimizersStatus OptimizersStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CollectionParams Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsAggregatedTelemetry" /> class.
        /// </summary>
        /// <param name="vectors"></param>
        /// <param name="optimizersStatus">
        /// Current state of the collection
        /// </param>
        /// <param name="params"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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