//HintName: G.Models.InterruptionAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InterruptionAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Duration> Details { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interruption_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double InterruptionCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InterruptionAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="interruptionCount"></param>
        public InterruptionAnalysis(
            global::System.Collections.Generic.IList<global::G.Duration> details,
            double interruptionCount)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.InterruptionCount = interruptionCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterruptionAnalysis" /> class.
        /// </summary>
        public InterruptionAnalysis()
        {
        }
    }
}