//HintName: G.Models.OpenSpaceMemberListData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenSpaceMemberListData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::G.OpenSpaceMember>? Items { get; set; }

        /// <summary>
        /// 空间成员总数
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSpaceMemberListData" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="totalCount">
        /// 空间成员总数
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenSpaceMemberListData(
            global::System.Collections.Generic.IList<global::G.OpenSpaceMember>? items,
            int? totalCount)
        {
            this.Items = items;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSpaceMemberListData" /> class.
        /// </summary>
        public OpenSpaceMemberListData()
        {
        }
    }
}