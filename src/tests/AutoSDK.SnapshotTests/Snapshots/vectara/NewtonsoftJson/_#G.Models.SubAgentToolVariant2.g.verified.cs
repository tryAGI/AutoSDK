//HintName: G.Models.SubAgentToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubAgentToolVariant2
    {
        /// <summary>
        /// This should always be `sub_agent`.<br/>
        /// Default Value: sub_agent<br/>
        /// Example: sub_agent
        /// </summary>
        /// <default>"sub_agent"</default>
        /// <example>sub_agent</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `sub_agent`.<br/>
        /// Default Value: sub_agent<br/>
        /// Example: sub_agent
        /// </param>
        public SubAgentToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentToolVariant2" /> class.
        /// </summary>
        public SubAgentToolVariant2()
        {
        }
    }
}