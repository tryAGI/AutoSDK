//HintName: G.Models.Condition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Condition
    {
        /// <summary>
        /// Condition key. Valid values:<br/>
        /// - `api_key` - Apply to a specific API key<br/>
        /// - `organisation_id` - Apply to an organization<br/>
        /// - `workspace_id` - Apply to a workspace<br/>
        /// - `metadata.*` - Apply based on custom metadata fields (e.g., `metadata.user_id`, `metadata.team`)<br/>
        /// Example: workspace_id
        /// </summary>
        /// <example>workspace_id</example>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Condition value<br/>
        /// Example: workspace-123
        /// </summary>
        /// <example>workspace-123</example>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        /// <param name="key">
        /// Condition key. Valid values:<br/>
        /// - `api_key` - Apply to a specific API key<br/>
        /// - `organisation_id` - Apply to an organization<br/>
        /// - `workspace_id` - Apply to a workspace<br/>
        /// - `metadata.*` - Apply based on custom metadata fields (e.g., `metadata.user_id`, `metadata.team`)<br/>
        /// Example: workspace_id
        /// </param>
        /// <param name="value">
        /// Condition value<br/>
        /// Example: workspace-123
        /// </param>
        public Condition(
            string key,
            string value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        public Condition()
        {
        }
    }
}