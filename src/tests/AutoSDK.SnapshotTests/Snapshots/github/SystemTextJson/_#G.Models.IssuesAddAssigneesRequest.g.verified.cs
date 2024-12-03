//HintName: G.Models.IssuesAddAssigneesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesAddAssigneesRequest
    {
        /// <summary>
        /// Usernames of people to assign this issue to. _NOTE: Only users with push access can add assignees to an issue. Assignees are silently ignored otherwise._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<string>? Assignees { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddAssigneesRequest" /> class.
        /// </summary>
        /// <param name="assignees">
        /// Usernames of people to assign this issue to. _NOTE: Only users with push access can add assignees to an issue. Assignees are silently ignored otherwise._
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public IssuesAddAssigneesRequest(
            global::System.Collections.Generic.IList<string>? assignees)
        {
            this.Assignees = assignees;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddAssigneesRequest" /> class.
        /// </summary>
        public IssuesAddAssigneesRequest()
        {
        }
    }
}