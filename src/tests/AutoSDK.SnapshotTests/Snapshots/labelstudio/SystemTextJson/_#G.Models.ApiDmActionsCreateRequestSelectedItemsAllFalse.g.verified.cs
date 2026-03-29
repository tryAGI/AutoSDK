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
        [global::System.Text.Json.Serialization.JsonPropertyName("all")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool All { get; set; }

        /// <summary>
        /// List of included task IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        public global::System.Collections.Generic.IList<int>? Included { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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