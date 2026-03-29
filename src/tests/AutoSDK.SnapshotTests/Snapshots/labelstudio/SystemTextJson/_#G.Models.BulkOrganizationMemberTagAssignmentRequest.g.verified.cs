//HintName: G.Models.BulkOrganizationMemberTagAssignmentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkOrganizationMemberTagAssignmentRequest
    {
        /// <summary>
        /// If true, assign tags to all organization members. If false, assign tags to the provided users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool All { get; set; }

        /// <summary>
        /// List of user IDs to exclude from the assignment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded")]
        public global::System.Collections.Generic.IList<int>? Excluded { get; set; }

        /// <summary>
        /// List of user IDs to include in the assignment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        public global::System.Collections.Generic.IList<int>? Included { get; set; }

        /// <summary>
        /// If true, replace all existing tag assignments for each user with the provided ones. If false, only add new assignments.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// List of tag IDs to assign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<int>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkOrganizationMemberTagAssignmentRequest" /> class.
        /// </summary>
        /// <param name="all">
        /// If true, assign tags to all organization members. If false, assign tags to the provided users.
        /// </param>
        /// <param name="excluded">
        /// List of user IDs to exclude from the assignment.
        /// </param>
        /// <param name="included">
        /// List of user IDs to include in the assignment.
        /// </param>
        /// <param name="overwrite">
        /// If true, replace all existing tag assignments for each user with the provided ones. If false, only add new assignments.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tags">
        /// List of tag IDs to assign.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkOrganizationMemberTagAssignmentRequest(
            bool all,
            global::System.Collections.Generic.IList<int>? excluded,
            global::System.Collections.Generic.IList<int>? included,
            bool? overwrite,
            global::System.Collections.Generic.IList<int>? tags)
        {
            this.All = all;
            this.Excluded = excluded;
            this.Included = included;
            this.Overwrite = overwrite;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkOrganizationMemberTagAssignmentRequest" /> class.
        /// </summary>
        public BulkOrganizationMemberTagAssignmentRequest()
        {
        }
    }
}