//HintName: G.Models.OpenAPIWorkflowList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIWorkflowList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OpenAPIWorkflowBasic> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIWorkflowList" /> class.
        /// </summary>
        /// <param name="hasMore"></param>
        /// <param name="items"></param>
        public OpenAPIWorkflowList(
            bool hasMore,
            global::System.Collections.Generic.IList<global::G.OpenAPIWorkflowBasic> items)
        {
            this.HasMore = hasMore;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIWorkflowList" /> class.
        /// </summary>
        public OpenAPIWorkflowList()
        {
        }
    }
}