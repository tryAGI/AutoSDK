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
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public int Input { get; set; } = default!;

        /// <summary>
        /// Number of output units (e.g. tokens)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public int Output { get; set; } = default!;

        /// <summary>
        /// Defaults to input+output if not set
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Unit of measurement
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// USD input cost
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputCost")]
        public double? InputCost { get; set; }

        /// <summary>
        /// USD output cost
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputCost")]
        public double? OutputCost { get; set; }

        /// <summary>
        /// USD total cost, defaults to input+output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalCost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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