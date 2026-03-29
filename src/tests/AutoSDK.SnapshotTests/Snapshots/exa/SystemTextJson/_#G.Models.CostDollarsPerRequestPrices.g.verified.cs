//HintName: G.Models.CostDollarsPerRequestPrices.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Standard price per request for different operations
    /// </summary>
    public sealed partial class CostDollarsPerRequestPrices
    {
        /// <summary>
        /// Standard price for neural search with 1-25 results<br/>
        /// Example: 0.005
        /// </summary>
        /// <example>0.005</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("neuralSearch_1_25_results")]
        public float? NeuralSearch125Results { get; set; }

        /// <summary>
        /// Standard price for neural search with 26-100 results<br/>
        /// Example: 0.025
        /// </summary>
        /// <example>0.025</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("neuralSearch_26_100_results")]
        public float? NeuralSearch26100Results { get; set; }

        /// <summary>
        /// Standard price for neural search with 100+ results<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("neuralSearch_100_plus_results")]
        public float? NeuralSearch100PlusResults { get; set; }

        /// <summary>
        /// Standard price for deep search with 1-25 results<br/>
        /// Example: 0.015
        /// </summary>
        /// <example>0.015</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepSearch_1_25_results")]
        public float? DeepSearch125Results { get; set; }

        /// <summary>
        /// Standard price for deep search with 26-100 results<br/>
        /// Example: 0.075
        /// </summary>
        /// <example>0.075</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepSearch_26_100_results")]
        public float? DeepSearch26100Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsPerRequestPrices" /> class.
        /// </summary>
        /// <param name="neuralSearch125Results">
        /// Standard price for neural search with 1-25 results<br/>
        /// Example: 0.005
        /// </param>
        /// <param name="neuralSearch26100Results">
        /// Standard price for neural search with 26-100 results<br/>
        /// Example: 0.025
        /// </param>
        /// <param name="neuralSearch100PlusResults">
        /// Standard price for neural search with 100+ results<br/>
        /// Example: 1
        /// </param>
        /// <param name="deepSearch125Results">
        /// Standard price for deep search with 1-25 results<br/>
        /// Example: 0.015
        /// </param>
        /// <param name="deepSearch26100Results">
        /// Standard price for deep search with 26-100 results<br/>
        /// Example: 0.075
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostDollarsPerRequestPrices(
            float? neuralSearch125Results,
            float? neuralSearch26100Results,
            float? neuralSearch100PlusResults,
            float? deepSearch125Results,
            float? deepSearch26100Results)
        {
            this.NeuralSearch125Results = neuralSearch125Results;
            this.NeuralSearch26100Results = neuralSearch26100Results;
            this.NeuralSearch100PlusResults = neuralSearch100PlusResults;
            this.DeepSearch125Results = deepSearch125Results;
            this.DeepSearch26100Results = deepSearch26100Results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsPerRequestPrices" /> class.
        /// </summary>
        public CostDollarsPerRequestPrices()
        {
        }
    }
}