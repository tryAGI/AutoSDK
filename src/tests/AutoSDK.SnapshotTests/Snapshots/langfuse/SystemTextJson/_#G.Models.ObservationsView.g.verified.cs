//HintName: G.Models.ObservationsView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObservationsView
    {
        /// <summary>
        /// The name of the prompt associated with the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptName")]
        public string? PromptName { get; set; }

        /// <summary>
        /// The version of the prompt associated with the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersion")]
        public int? PromptVersion { get; set; }

        /// <summary>
        /// The unique identifier of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// The price of the input in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputPrice")]
        public double? InputPrice { get; set; }

        /// <summary>
        /// The price of the output in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputPrice")]
        public double? OutputPrice { get; set; }

        /// <summary>
        /// The total price in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPrice")]
        public double? TotalPrice { get; set; }

        /// <summary>
        /// (Deprecated. Use usageDetails and costDetails instead.) The calculated cost of the input in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calculatedInputCost")]
        public double? CalculatedInputCost { get; set; }

        /// <summary>
        /// (Deprecated. Use usageDetails and costDetails instead.) The calculated cost of the output in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calculatedOutputCost")]
        public double? CalculatedOutputCost { get; set; }

        /// <summary>
        /// (Deprecated. Use usageDetails and costDetails instead.) The calculated total cost in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calculatedTotalCost")]
        public double? CalculatedTotalCost { get; set; }

        /// <summary>
        /// The latency in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// The time to the first token in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeToFirstToken")]
        public double? TimeToFirstToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationsView" /> class.
        /// </summary>
        /// <param name="promptName">
        /// The name of the prompt associated with the observation
        /// </param>
        /// <param name="promptVersion">
        /// The version of the prompt associated with the observation
        /// </param>
        /// <param name="modelId">
        /// The unique identifier of the model
        /// </param>
        /// <param name="inputPrice">
        /// The price of the input in USD
        /// </param>
        /// <param name="outputPrice">
        /// The price of the output in USD.
        /// </param>
        /// <param name="totalPrice">
        /// The total price in USD.
        /// </param>
        /// <param name="calculatedInputCost">
        /// (Deprecated. Use usageDetails and costDetails instead.) The calculated cost of the input in USD
        /// </param>
        /// <param name="calculatedOutputCost">
        /// (Deprecated. Use usageDetails and costDetails instead.) The calculated cost of the output in USD
        /// </param>
        /// <param name="calculatedTotalCost">
        /// (Deprecated. Use usageDetails and costDetails instead.) The calculated total cost in USD
        /// </param>
        /// <param name="latency">
        /// The latency in seconds.
        /// </param>
        /// <param name="timeToFirstToken">
        /// The time to the first token in seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservationsView(
            string? promptName,
            int? promptVersion,
            string? modelId,
            double? inputPrice,
            double? outputPrice,
            double? totalPrice,
            double? calculatedInputCost,
            double? calculatedOutputCost,
            double? calculatedTotalCost,
            double? latency,
            double? timeToFirstToken)
        {
            this.PromptName = promptName;
            this.PromptVersion = promptVersion;
            this.ModelId = modelId;
            this.InputPrice = inputPrice;
            this.OutputPrice = outputPrice;
            this.TotalPrice = totalPrice;
            this.CalculatedInputCost = calculatedInputCost;
            this.CalculatedOutputCost = calculatedOutputCost;
            this.CalculatedTotalCost = calculatedTotalCost;
            this.Latency = latency;
            this.TimeToFirstToken = timeToFirstToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationsView" /> class.
        /// </summary>
        public ObservationsView()
        {
        }
    }
}