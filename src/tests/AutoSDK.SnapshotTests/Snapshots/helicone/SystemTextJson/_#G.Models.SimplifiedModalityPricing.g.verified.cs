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
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public double? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedInput")]
        public double? CachedInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public double? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplifiedModalityPricing" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cachedInput"></param>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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