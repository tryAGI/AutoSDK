//HintName: G.Models.PersonalizedVideoAddContactRequestVariablesListItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PersonalizedVideoAddContactRequestVariablesListItem
    {
        /// <summary>
        /// Example: john@mail.com
        /// </summary>
        /// <example>john@mail.com</example>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Example: John
        /// </summary>
        /// <example>John</example>
        [global::Newtonsoft.Json.JsonProperty("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalizedVideoAddContactRequestVariablesListItem" /> class.
        /// </summary>
        /// <param name="email">
        /// Example: john@mail.com
        /// </param>
        /// <param name="firstName">
        /// Example: John
        /// </param>
        public PersonalizedVideoAddContactRequestVariablesListItem(
            string? email,
            string? firstName)
        {
            this.Email = email;
            this.FirstName = firstName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalizedVideoAddContactRequestVariablesListItem" /> class.
        /// </summary>
        public PersonalizedVideoAddContactRequestVariablesListItem()
        {
        }
    }
}