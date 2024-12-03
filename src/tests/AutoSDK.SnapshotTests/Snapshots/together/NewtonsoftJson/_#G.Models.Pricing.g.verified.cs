//HintName: G.Models.Pricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Pricing
    {
        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("base", Required = global::Newtonsoft.Json.Required.Always)]
        public double Base { get; set; } = default!;

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("finetune", Required = global::Newtonsoft.Json.Required.Always)]
        public double Finetune { get; set; } = default!;

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("hourly", Required = global::Newtonsoft.Json.Required.Always)]
        public double Hourly { get; set; } = default!;

        /// <summary>
        /// Example: 0.3
        /// </summary>
        /// <example>0.3</example>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public double Input { get; set; } = default!;

        /// <summary>
        /// Example: 0.3
        /// </summary>
        /// <example>0.3</example>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public double Output { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pricing" /> class.
        /// </summary>
        /// <param name="base">
        /// Example: 0
        /// </param>
        /// <param name="finetune">
        /// Example: 0
        /// </param>
        /// <param name="hourly">
        /// Example: 0
        /// </param>
        /// <param name="input">
        /// Example: 0.3
        /// </param>
        /// <param name="output">
        /// Example: 0.3
        /// </param>
        public Pricing(
            double @base,
            double finetune,
            double hourly,
            double input,
            double output)
        {
            this.Base = @base;
            this.Finetune = finetune;
            this.Hourly = hourly;
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pricing" /> class.
        /// </summary>
        public Pricing()
        {
        }
    }
}