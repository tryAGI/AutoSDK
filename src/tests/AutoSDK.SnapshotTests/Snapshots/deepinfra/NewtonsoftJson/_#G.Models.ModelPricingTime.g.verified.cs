//HintName: G.Models.ModelPricingTime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingTime
    {
        /// <summary>
        /// Default Value: time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cents_per_sec", Required = global::Newtonsoft.Json.Required.Always)]
        public double CentsPerSec { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingTime" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: time
        /// </param>
        /// <param name="centsPerSec"></param>
        public ModelPricingTime(
            double centsPerSec,
            string? type)
        {
            this.CentsPerSec = centsPerSec;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingTime" /> class.
        /// </summary>
        public ModelPricingTime()
        {
        }
    }
}