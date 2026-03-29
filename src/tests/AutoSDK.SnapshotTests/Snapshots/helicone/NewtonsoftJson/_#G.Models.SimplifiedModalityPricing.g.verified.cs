//HintName: G.Models.SimplifiedModalityPricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimplifiedModalityPricing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public double? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cachedInput")]
        public double? CachedInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public double? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplifiedModalityPricing" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cachedInput"></param>
        /// <param name="output"></param>
        public SimplifiedModalityPricing(
            double? input,
            double? cachedInput,
            double? output)
        {
            this.Input = input;
            this.CachedInput = cachedInput;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplifiedModalityPricing" /> class.
        /// </summary>
        public SimplifiedModalityPricing()
        {
        }
    }
}