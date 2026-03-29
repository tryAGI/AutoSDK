//HintName: G.Models.GroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupBy
    {
        /// <summary>
        /// Group by key. Valid values:<br/>
        /// - `api_key` - Group by API key<br/>
        /// - `organisation_id` - Group by organization<br/>
        /// - `workspace_id` - Group by workspace<br/>
        /// - `metadata.*` - Group by custom metadata fields<br/>
        /// Example: api_key
        /// </summary>
        /// <example>api_key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupBy" /> class.
        /// </summary>
        /// <param name="key">
        /// Group by key. Valid values:<br/>
        /// - `api_key` - Group by API key<br/>
        /// - `organisation_id` - Group by organization<br/>
        /// - `workspace_id` - Group by workspace<br/>
        /// - `metadata.*` - Group by custom metadata fields<br/>
        /// Example: api_key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupBy(
            string key)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupBy" /> class.
        /// </summary>
        public GroupBy()
        {
        }
    }
}