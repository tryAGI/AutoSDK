//HintName: G.Models.IssuesRemoveAssigneesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesRemoveAssigneesRequest
    {
        /// <summary>
        /// Usernames of assignees to remove from an issue. _NOTE: Only users with push access can remove assignees from an issue. Assignees are silently ignored otherwise._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<string>? Assignees { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesRemoveAssigneesRequest" /> class.
        /// </summary>
        /// <param name="assignees">
        /// Usernames of assignees to remove from an issue. _NOTE: Only users with push access can remove assignees from an issue. Assignees are silently ignored otherwise._
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesRemoveAssigneesRequest(
            global::System.Collections.Generic.IList<string>? assignees)
        {
            this.Assignees = assignees;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesRemoveAssigneesRequest" /> class.
        /// </summary>
        public IssuesRemoveAssigneesRequest()
        {
        }
    }
}