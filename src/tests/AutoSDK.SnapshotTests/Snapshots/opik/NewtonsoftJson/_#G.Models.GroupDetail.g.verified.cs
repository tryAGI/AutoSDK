//HintName: G.Models.GroupDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_sorting")]
        public global::System.Collections.Generic.IList<string>? GroupSorting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupDetail" /> class.
        /// </summary>
        /// <param name="groupSorting"></param>
        public GroupDetail(
            global::System.Collections.Generic.IList<string>? groupSorting)
        {
            this.GroupSorting = groupSorting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupDetail" /> class.
        /// </summary>
        public GroupDetail()
        {
        }
    }
}