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
        [global::System.Text.Json.Serialization.JsonPropertyName("all")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool All { get; set; }

        /// <summary>
        /// List of excluded task IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded")]
        public global::System.Collections.Generic.IList<int>? Excluded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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