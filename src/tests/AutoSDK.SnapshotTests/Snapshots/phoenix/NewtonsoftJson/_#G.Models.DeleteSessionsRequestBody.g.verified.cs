//HintName: G.Models.DeleteSessionsRequestBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteSessionsRequestBody
    {
        /// <summary>
        /// List of session identifiers to delete. All identifiers must be the same type: either all GlobalIDs or all user-provided session_id strings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_identifiers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> SessionIdentifiers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSessionsRequestBody" /> class.
        /// </summary>
        /// <param name="sessionIdentifiers">
        /// List of session identifiers to delete. All identifiers must be the same type: either all GlobalIDs or all user-provided session_id strings.
        /// </param>
        public DeleteSessionsRequestBody(
            global::System.Collections.Generic.IList<string> sessionIdentifiers)
        {
            this.SessionIdentifiers = sessionIdentifiers ?? throw new global::System.ArgumentNullException(nameof(sessionIdentifiers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSessionsRequestBody" /> class.
        /// </summary>
        public DeleteSessionsRequestBody()
        {
        }
    }
}