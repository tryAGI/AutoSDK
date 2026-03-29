//HintName: G.Models.UpdateStyleRuleListRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateStyleRuleListRequest
    {
        /// <summary>
        /// Name of the style rule list<br/>
        /// Example: New Technical Documentation Rules
        /// </summary>
        /// <example>New Technical Documentation Rules</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStyleRuleListRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the style rule list<br/>
        /// Example: New Technical Documentation Rules
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateStyleRuleListRequest(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStyleRuleListRequest" /> class.
        /// </summary>
        public UpdateStyleRuleListRequest()
        {
        }
    }
}