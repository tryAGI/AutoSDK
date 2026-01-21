//HintName: G.Models.ListGeneratedItemsV1HistoryGetStartAfterHistoryItemId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// After which ID to start fetching, use this parameter to paginate across a large collection of history items. In case this parameter is not provided history items will be fetched starting from the most recently created one ordered descending by their creation date.
    /// </summary>
    public sealed partial class ListGeneratedItemsV1HistoryGetStartAfterHistoryItemId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}