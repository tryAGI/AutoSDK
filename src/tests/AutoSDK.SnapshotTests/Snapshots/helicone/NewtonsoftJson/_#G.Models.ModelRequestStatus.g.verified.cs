//HintName: G.Models.ModelRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorRate", Required = global::Newtonsoft.Json.Required.Always)]
        public double ErrorRate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("successRate", Required = global::Newtonsoft.Json.Required.Always)]
        public double SuccessRate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRequestStatus" /> class.
        /// </summary>
        /// <param name="errorRate"></param>
        /// <param name="successRate"></param>
        public ModelRequestStatus(
            double errorRate,
            double successRate)
        {
            this.ErrorRate = errorRate;
            this.SuccessRate = successRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRequestStatus" /> class.
        /// </summary>
        public ModelRequestStatus()
        {
        }
    }
}