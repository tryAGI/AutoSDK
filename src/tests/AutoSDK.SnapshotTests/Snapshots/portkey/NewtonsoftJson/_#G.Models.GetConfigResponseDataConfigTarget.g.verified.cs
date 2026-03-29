//HintName: G.Models.GetConfigResponseDataConfigTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigResponseDataConfigTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("virtual_key")]
        public string? VirtualKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigResponseDataConfigTarget" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="virtualKey"></param>
        public GetConfigResponseDataConfigTarget(
            string? provider,
            string? virtualKey)
        {
            this.Provider = provider;
            this.VirtualKey = virtualKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigResponseDataConfigTarget" /> class.
        /// </summary>
        public GetConfigResponseDataConfigTarget()
        {
        }
    }
}