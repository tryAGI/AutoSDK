//HintName: G.Models.PartialPromptToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialPromptToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.PartialTextOperators? Id { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_defined_id")]
        public global::G.PartialTextOperators? UserDefinedId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPromptToOperators" /> class.
        /// </summary>
        /// <param name="id">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userDefinedId">
        /// Make all properties in T optional
        /// </param>
        public PartialPromptToOperators(
            global::G.PartialTextOperators? id,
            global::G.PartialTextOperators? userDefinedId)
        {
            this.Id = id;
            this.UserDefinedId = userDefinedId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPromptToOperators" /> class.
        /// </summary>
        public PartialPromptToOperators()
        {
        }
    }
}