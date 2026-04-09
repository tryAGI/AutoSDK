//HintName: G.Models.WorkspaceMemberList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceMemberList
    {
        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Example: list
        /// </summary>
        /// <example>list</example>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WorkspaceMemberListObjectJsonConverter))]
        public global::G.WorkspaceMemberListObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.WorkspaceMember>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMemberList" /> class.
        /// </summary>
        /// <param name="total">
        /// Example: 2
        /// </param>
        /// <param name="object">
        /// Example: list
        /// </param>
        /// <param name="data"></param>
        public WorkspaceMemberList(
            int? total,
            global::G.WorkspaceMemberListObject? @object,
            global::System.Collections.Generic.IList<global::G.WorkspaceMember>? data)
        {
            this.Total = total;
            this.Object = @object;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMemberList" /> class.
        /// </summary>
        public WorkspaceMemberList()
        {
        }
    }
}