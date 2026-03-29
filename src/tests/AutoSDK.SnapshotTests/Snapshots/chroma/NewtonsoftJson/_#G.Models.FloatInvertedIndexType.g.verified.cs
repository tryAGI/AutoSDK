//HintName: G.Models.FloatInvertedIndexType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FloatInvertedIndexType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FloatInvertedIndexConfig Config { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="FloatInvertedIndexType" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="enabled"></param>
        public FloatInvertedIndexType(
            global::G.FloatInvertedIndexConfig config,
            bool enabled)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatInvertedIndexType" /> class.
        /// </summary>
        public FloatInvertedIndexType()
        {
        }
    }
}