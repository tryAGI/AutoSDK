//HintName: G.Models.ApiDmActionsCreateRequestSelectedItemsAllFalse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiDmActionsCreateRequestSelectedItemsAllFalse
    {
        /// <summary>
        /// No tasks are selected
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("all", Required = global::Newtonsoft.Json.Required.Always)]
        public bool All { get; set; } = default!;

        /// <summary>
        /// List of included task IDs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("included")]
        public global::System.Collections.Generic.IList<int>? Included { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmActionsCreateRequestSelectedItemsAllFalse" /> class.
        /// </summary>
        /// <param name="all">
        /// No tasks are selected
        /// </param>
        /// <param name="included">
        /// List of included task IDs
        /// </param>
        public ApiDmActionsCreateRequestSelectedItemsAllFalse(
            bool all,
            global::System.Collections.Generic.IList<int>? included)
        {
            this.All = all;
            this.Included = included;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmActionsCreateRequestSelectedItemsAllFalse" /> class.
        /// </summary>
        public ApiDmActionsCreateRequestSelectedItemsAllFalse()
        {
        }
    }
}