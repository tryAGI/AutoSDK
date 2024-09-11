//HintName: G.Models.PersonalizedVideoAddContactRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PersonalizedVideoAddContactRequest
    {
        /// <summary>
        /// Example: &lt;project_id&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables_list")]
        public global::System.Collections.Generic.IList<global::G.PersonalizedVideoAddContactRequestVariablesListItem>? VariablesList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}