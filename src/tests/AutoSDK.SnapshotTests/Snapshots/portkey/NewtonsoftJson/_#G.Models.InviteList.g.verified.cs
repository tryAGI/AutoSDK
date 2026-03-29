//HintName: G.Models.InviteList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.InviteListObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.Invite>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteList" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="total"></param>
        /// <param name="data"></param>
        public InviteList(
            global::G.InviteListObject? @object,
            int? total,
            global::System.Collections.Generic.IList<global::G.Invite>? data)
        {
            this.Object = @object;
            this.Total = total;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteList" /> class.
        /// </summary>
        public InviteList()
        {
        }
    }
}