//HintName: G.Models.Usage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// (Deprecated. Use usageDetails and costDetails instead.) Standard interface for usage and cost
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// Number of input units (e.g. tokens)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Input { get; set; }

        /// <summary>
        /// Number of output units (e.g. tokens)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Output { get; set; }

        /// <summary>
        /// Defaults to input+output if not set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Unit of measurement
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// USD input cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputCost")]
        public double? InputCost { get; set; }

        /// <summary>
        /// USD output cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCost")]
        public double? OutputCost { get; set; }

        /// <summary>
        /// USD total cost, defaults to input+output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="input">
        /// Number of input units (e.g. tokens)
        /// </param>
        /// <param name="output">
        /// Number of output units (e.g. tokens)
        /// </param>
        /// <param name="total">
        /// Defaults to input+output if not set
        /// </param>
        /// <param name="unit">
        /// Unit of measurement
        /// </param>
        /// <param name="inputCost">
        /// USD input cost
        /// </param>
        /// <param name="outputCost">
        /// USD output cost
        /// </param>
        /// <param name="totalCost">
        /// USD total cost, defaults to input+output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Usage(
            int input,
            int output,
            int total,
            string? unit,
            double? inputCost,
            double? outputCost,
            double? totalCost)
        {
            this.Input = input;
            this.Output = output;
            this.Total = total;
            this.Unit = unit;
            this.InputCost = inputCost;
            this.OutputCost = outputCost;
            this.TotalCost = totalCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }
    }
}