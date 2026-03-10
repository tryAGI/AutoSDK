//HintName: G.Models.AgentSuccessfulResponseExample.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentSuccessfulResponseExample
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public string Response { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"success"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "success";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSuccessfulResponseExample" /> class.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="type"></param>
        public AgentSuccessfulResponseExample(
            string response,
            string type = "success")
        {
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSuccessfulResponseExample" /> class.
        /// </summary>
        public AgentSuccessfulResponseExample()
        {
        }
    }
}