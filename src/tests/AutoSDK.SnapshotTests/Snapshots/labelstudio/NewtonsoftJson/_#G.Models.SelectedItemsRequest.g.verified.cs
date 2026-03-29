//HintName: G.Models.SelectedItemsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SelectedItemsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("all", Required = global::Newtonsoft.Json.Required.Always)]
        public bool All { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excluded")]
        public global::System.Collections.Generic.IList<int>? Excluded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("included")]
        public global::System.Collections.Generic.IList<int>? Included { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedItemsRequest" /> class.
        /// </summary>
        /// <param name="all"></param>
        /// <param name="excluded"></param>
        /// <param name="included"></param>
        public SelectedItemsRequest(
            bool all,
            global::System.Collections.Generic.IList<int>? excluded,
            global::System.Collections.Generic.IList<int>? included)
        {
            this.All = all;
            this.Excluded = excluded;
            this.Included = included;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedItemsRequest" /> class.
        /// </summary>
        public SelectedItemsRequest()
        {
        }
    }
}