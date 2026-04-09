//HintName: G.Models.WorkspaceList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceList
    {
        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WorkspaceListObjectJsonConverter))]
        public global::G.WorkspaceListObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.Workspace>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceList" /> class.
        /// </summary>
        /// <param name="total">
        /// Example: 2
        /// </param>
        /// <param name="object"></param>
        /// <param name="data"></param>
        public WorkspaceList(
            int? total,
            global::G.WorkspaceListObject? @object,
            global::System.Collections.Generic.IList<global::G.Workspace>? data)
        {
            this.Total = total;
            this.Object = @object;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceList" /> class.
        /// </summary>
        public WorkspaceList()
        {
        }
    }
}