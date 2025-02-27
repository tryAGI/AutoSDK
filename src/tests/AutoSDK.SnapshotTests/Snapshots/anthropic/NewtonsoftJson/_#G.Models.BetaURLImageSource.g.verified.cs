//HintName: G.Models.BetaURLImageSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaURLImageSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaURLImageSourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaURLImageSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="url"></param>
        public BetaURLImageSource(
            string url,
            global::G.BetaURLImageSourceType type)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaURLImageSource" /> class.
        /// </summary>
        public BetaURLImageSource()
        {
        }
    }
}