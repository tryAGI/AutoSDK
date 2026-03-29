//HintName: G.Models.V2CallBaseLlmTokenUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// LLM token usage of the call, available after call ends. Not populated if using custom LLM, realtime API, or no LLM call is made.
    /// </summary>
    public sealed partial class V2CallBaseLlmTokenUsage
    {
        /// <summary>
        /// All the token count values in the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Values { get; set; } = default!;

        /// <summary>
        /// Average token count of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("average", Required = global::Newtonsoft.Json.Required.Always)]
        public double Average { get; set; } = default!;

        /// <summary>
        /// Number of requests made to the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public double NumRequests { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2CallBaseLlmTokenUsage" /> class.
        /// </summary>
        /// <param name="values">
        /// All the token count values in the call.
        /// </param>
        /// <param name="average">
        /// Average token count of the call.
        /// </param>
        /// <param name="numRequests">
        /// Number of requests made to the LLM.
        /// </param>
        public V2CallBaseLlmTokenUsage(
            global::System.Collections.Generic.IList<double> values,
            double average,
            double numRequests)
        {
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.Average = average;
            this.NumRequests = numRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2CallBaseLlmTokenUsage" /> class.
        /// </summary>
        public V2CallBaseLlmTokenUsage()
        {
        }
    }
}