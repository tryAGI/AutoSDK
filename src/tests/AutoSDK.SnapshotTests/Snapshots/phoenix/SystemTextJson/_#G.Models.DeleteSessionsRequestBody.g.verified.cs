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
        [global::System.Text.Json.Serialization.JsonPropertyName("session_identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SessionIdentifiers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSessionsRequestBody" /> class.
        /// </summary>
        /// <param name="sessionIdentifiers">
        /// List of session identifiers to delete. All identifiers must be the same type: either all GlobalIDs or all user-provided session_id strings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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