//HintName: G.Models.GroupDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups_details")]
        public global::System.Collections.Generic.IList<global::G.GroupDetail>? GroupsDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupDetails" /> class.
        /// </summary>
        /// <param name="groupsDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupDetails(
            global::System.Collections.Generic.IList<global::G.GroupDetail>? groupsDetails)
        {
            this.GroupsDetails = groupsDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupDetails" /> class.
        /// </summary>
        public GroupDetails()
        {
        }
    }
}