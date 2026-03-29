//HintName: G.Models.AudioEventsConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioEventsConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("types")]
        public global::System.Collections.Generic.IList<string>? Types { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEventsConfig" /> class.
        /// </summary>
        /// <param name="types"></param>
        public AudioEventsConfig(
            global::System.Collections.Generic.IList<string>? types)
        {
            this.Types = types;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEventsConfig" /> class.
        /// </summary>
        public AudioEventsConfig()
        {
        }
    }
}