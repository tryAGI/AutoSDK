//HintName: G.Models.AgentConfigEnvSetByName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfigEnvSetByName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blueprint_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlueprintName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigEnvSetByName" /> class.
        /// </summary>
        /// <param name="blueprintName"></param>
        public AgentConfigEnvSetByName(
            string blueprintName)
        {
            this.BlueprintName = blueprintName ?? throw new global::System.ArgumentNullException(nameof(blueprintName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigEnvSetByName" /> class.
        /// </summary>
        public AgentConfigEnvSetByName()
        {
        }
    }
}