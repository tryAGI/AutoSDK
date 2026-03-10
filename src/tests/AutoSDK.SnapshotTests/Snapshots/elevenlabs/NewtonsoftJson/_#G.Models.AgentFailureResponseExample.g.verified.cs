//HintName: G.Models.AgentFailureResponseExample.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentFailureResponseExample
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public string Response { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"failure"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "failure";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentFailureResponseExample" /> class.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="type"></param>
        public AgentFailureResponseExample(
            string response,
            string type = "failure")
        {
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentFailureResponseExample" /> class.
        /// </summary>
        public AgentFailureResponseExample()
        {
        }
    }
}