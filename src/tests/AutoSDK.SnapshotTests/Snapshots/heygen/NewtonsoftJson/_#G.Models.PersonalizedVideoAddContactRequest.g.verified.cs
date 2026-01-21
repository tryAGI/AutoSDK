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
        /// <example>&lt;project_id&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Example: [{"email":"john@mail.com","first_name":"John"}]
        /// </summary>
        /// <example>[{"email":"john@mail.com","first_name":"John"}]</example>
        [global::Newtonsoft.Json.JsonProperty("variables_list")]
        public global::System.Collections.Generic.IList<global::G.PersonalizedVideoAddContactRequestVariablesListItem>? VariablesList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalizedVideoAddContactRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Example: &lt;project_id&gt;
        /// </param>
        /// <param name="variablesList">
        /// Example: [{"email":"john@mail.com","first_name":"John"}]
        /// </param>
        public PersonalizedVideoAddContactRequest(
            string? projectId,
            global::System.Collections.Generic.IList<global::G.PersonalizedVideoAddContactRequestVariablesListItem>? variablesList)
        {
            this.ProjectId = projectId;
            this.VariablesList = variablesList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalizedVideoAddContactRequest" /> class.
        /// </summary>
        public PersonalizedVideoAddContactRequest()
        {
        }
    }
}