//HintName: G.Models.ListMyAgentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMyAgentsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AllOf<global::G.ListMyAgentsResponseAgentVariant1, global::G.ListMyAgentsResponseAgentVariant2>> Agents { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMyAgentsResponse" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="token"></param>
        public ListMyAgentsResponse(
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.ListMyAgentsResponseAgentVariant1, global::G.ListMyAgentsResponseAgentVariant2>> agents,
            string? token)
        {
            this.Token = token;
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMyAgentsResponse" /> class.
        /// </summary>
        public ListMyAgentsResponse()
        {
        }
    }
}