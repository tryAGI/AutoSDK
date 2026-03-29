//HintName: G.Models.SttLayer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttLayer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stt_engine")]
        public string? SttEngine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hotwords")]
        public global::System.Collections.Generic.IList<string>? Hotwords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttLayer" /> class.
        /// </summary>
        /// <param name="sttEngine"></param>
        /// <param name="hotwords"></param>
        public SttLayer(
            string? sttEngine,
            global::System.Collections.Generic.IList<string>? hotwords)
        {
            this.SttEngine = sttEngine;
            this.Hotwords = hotwords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttLayer" /> class.
        /// </summary>
        public SttLayer()
        {
        }
    }
}