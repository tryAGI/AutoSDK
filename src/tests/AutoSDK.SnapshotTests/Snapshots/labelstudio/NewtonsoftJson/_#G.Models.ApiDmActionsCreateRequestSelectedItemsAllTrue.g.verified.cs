//HintName: G.Models.ApiDmActionsCreateRequestSelectedItemsAllTrue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiDmActionsCreateRequestSelectedItemsAllTrue
    {
        /// <summary>
        /// All tasks are selected
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("all", Required = global::Newtonsoft.Json.Required.Always)]
        public bool All { get; set; } = default!;

        /// <summary>
        /// List of excluded task IDs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excluded")]
        public global::System.Collections.Generic.IList<int>? Excluded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmActionsCreateRequestSelectedItemsAllTrue" /> class.
        /// </summary>
        /// <param name="all">
        /// All tasks are selected
        /// </param>
        /// <param name="excluded">
        /// List of excluded task IDs
        /// </param>
        public ApiDmActionsCreateRequestSelectedItemsAllTrue(
            bool all,
            global::System.Collections.Generic.IList<int>? excluded)
        {
            this.All = all;
            this.Excluded = excluded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmActionsCreateRequestSelectedItemsAllTrue" /> class.
        /// </summary>
        public ApiDmActionsCreateRequestSelectedItemsAllTrue()
        {
        }
    }
}