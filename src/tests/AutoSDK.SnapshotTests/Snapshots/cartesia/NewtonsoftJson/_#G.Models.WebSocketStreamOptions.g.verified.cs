//HintName: G.Models.WebSocketStreamOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSocketStreamOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketStreamOptions" /> class.
        /// </summary>
        /// <param name="timeout"></param>
        public WebSocketStreamOptions(
            double? timeout)
        {
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketStreamOptions" /> class.
        /// </summary>
        public WebSocketStreamOptions()
        {
        }
    }
}