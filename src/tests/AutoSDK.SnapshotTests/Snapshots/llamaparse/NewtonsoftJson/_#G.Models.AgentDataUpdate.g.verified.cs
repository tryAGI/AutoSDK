//HintName: G.Models.AgentDataUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API request model for updating agent data
    /// </summary>
    public sealed partial class AgentDataUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public object Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDataUpdate" /> class.
        /// </summary>
        /// <param name="data"></param>
        public AgentDataUpdate(
            object data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDataUpdate" /> class.
        /// </summary>
        public AgentDataUpdate()
        {
        }
    }
}