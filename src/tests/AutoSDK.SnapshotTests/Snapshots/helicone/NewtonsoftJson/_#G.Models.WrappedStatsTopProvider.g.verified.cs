//HintName: G.Models.WrappedStatsTopProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WrappedStatsTopProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WrappedStatsTopProvider" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="provider"></param>
        public WrappedStatsTopProvider(
            double count,
            string provider)
        {
            this.Count = count;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WrappedStatsTopProvider" /> class.
        /// </summary>
        public WrappedStatsTopProvider()
        {
        }
    }
}