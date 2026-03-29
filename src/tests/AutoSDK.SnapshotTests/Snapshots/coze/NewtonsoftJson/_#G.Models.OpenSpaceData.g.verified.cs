//HintName: G.Models.OpenSpaceData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenSpaceData
    {
        /// <summary>
        /// 空间总数
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspaces")]
        public global::System.Collections.Generic.IList<global::G.OpenSpace>? Workspaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSpaceData" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// 空间总数
        /// </param>
        /// <param name="workspaces"></param>
        public OpenSpaceData(
            int? totalCount,
            global::System.Collections.Generic.IList<global::G.OpenSpace>? workspaces)
        {
            this.TotalCount = totalCount;
            this.Workspaces = workspaces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSpaceData" /> class.
        /// </summary>
        public OpenSpaceData()
        {
        }
    }
}