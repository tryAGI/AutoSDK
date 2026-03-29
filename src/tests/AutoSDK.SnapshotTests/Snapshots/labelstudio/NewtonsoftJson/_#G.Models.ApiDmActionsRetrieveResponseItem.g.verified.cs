//HintName: G.Models.ApiDmActionsRetrieveResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiDmActionsRetrieveResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dialog")]
        public global::G.ApiDmActionsRetrieveResponseItemDialog? Dialog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimental")]
        public bool? Experimental { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("order")]
        public int? Order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? Permission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmActionsRetrieveResponseItem" /> class.
        /// </summary>
        /// <param name="dialog"></param>
        /// <param name="experimental"></param>
        /// <param name="id"></param>
        /// <param name="order"></param>
        /// <param name="permission"></param>
        /// <param name="title"></param>
        public ApiDmActionsRetrieveResponseItem(
            global::G.ApiDmActionsRetrieveResponseItemDialog? dialog,
            bool? experimental,
            string? id,
            int? order,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? permission,
            string? title)
        {
            this.Dialog = dialog;
            this.Experimental = experimental;
            this.Id = id;
            this.Order = order;
            this.Permission = permission;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmActionsRetrieveResponseItem" /> class.
        /// </summary>
        public ApiDmActionsRetrieveResponseItem()
        {
        }
    }
}