//HintName: G.Models.IntInvertedIndexType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntInvertedIndexType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.IntInvertedIndexConfig Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntInvertedIndexType" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="enabled"></param>
        public IntInvertedIndexType(
            global::G.IntInvertedIndexConfig config,
            bool enabled)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntInvertedIndexType" /> class.
        /// </summary>
        public IntInvertedIndexType()
        {
        }
    }
}