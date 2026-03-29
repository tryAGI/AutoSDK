//HintName: G.Models.WrappedStatsTotalTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WrappedStatsTotalTokens
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public double Total { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cacheRead", Required = global::Newtonsoft.Json.Required.Always)]
        public double CacheRead { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cacheWrite", Required = global::Newtonsoft.Json.Required.Always)]
        public double CacheWrite { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion", Required = global::Newtonsoft.Json.Required.Always)]
        public double Completion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public double Prompt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WrappedStatsTotalTokens" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="cacheRead"></param>
        /// <param name="cacheWrite"></param>
        /// <param name="completion"></param>
        /// <param name="prompt"></param>
        public WrappedStatsTotalTokens(
            double total,
            double cacheRead,
            double cacheWrite,
            double completion,
            double prompt)
        {
            this.Total = total;
            this.CacheRead = cacheRead;
            this.CacheWrite = cacheWrite;
            this.Completion = completion;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WrappedStatsTotalTokens" /> class.
        /// </summary>
        public WrappedStatsTotalTokens()
        {
        }
    }
}