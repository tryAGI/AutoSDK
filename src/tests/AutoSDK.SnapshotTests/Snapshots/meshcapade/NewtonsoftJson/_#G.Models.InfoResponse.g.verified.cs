//HintName: G.Models.InfoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        public InfoResponse(
            string? version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoResponse" /> class.
        /// </summary>
        public InfoResponse()
        {
        }
    }
}