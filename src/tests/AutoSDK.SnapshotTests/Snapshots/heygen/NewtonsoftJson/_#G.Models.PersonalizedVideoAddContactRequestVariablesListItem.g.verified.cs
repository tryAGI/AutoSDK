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
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Example: John
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}