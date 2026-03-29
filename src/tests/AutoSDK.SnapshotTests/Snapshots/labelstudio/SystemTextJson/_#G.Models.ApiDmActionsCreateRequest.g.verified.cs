//HintName: G.Models.ApiDmActionsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data payload containing task filters, selected task items, and ordering<br/>
    /// Example: {"filters":{"conjunction":"or","items":[{"filter":"filter:tasks:id","operator":"greater","type":"Number","value":123}]},"ordering":["tasks:total_annotations"],"selectedItems":{"all":true,"excluded":[124,125,126]}}
    /// </summary>
    public sealed partial class ApiDmActionsCreateRequest
    {
        /// <summary>
        /// Filters to apply on tasks. You can use [the helper class `Filters` from this page](https://labelstud.io/sdk/data_manager.html) to create Data Manager Filters.Example: `{"conjunction": "or", "items": [{"filter": "filter:tasks:completed_at", "operator": "greater", "type": "Datetime", "value": "2021-01-01T00:00:00.000Z"}]}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::G.ApiDmActionsCreateRequestFilters? Filters { get; set; }

        /// <summary>
        /// List of fields to order by. Fields are similar to filters but without the `filter:` prefix. To reverse the order, add a minus sign before the field name, e.g. `-tasks:created_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordering")]
        public global::System.Collections.Generic.IList<global::G.ApiDmActionsCreateRequestOrderingItem>? Ordering { get; set; }

        /// <summary>
        /// Task selection by IDs. If filters are applied, the selection will be applied to the filtered tasks.If "all" is `false`, `"included"` must be used. If "all" is `true`, `"excluded"` must be used.Examples: `{"all": false, "included": [1, 2, 3]}` or `{"all": true, "excluded": [4, 5]}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectedItems")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ApiDmActionsCreateRequestSelectedItemsAllFalse, global::G.ApiDmActionsCreateRequestSelectedItemsAllTrue>))]
        public global::G.OneOf<global::G.ApiDmActionsCreateRequestSelectedItemsAllFalse, global::G.ApiDmActionsCreateRequestSelectedItemsAllTrue>? SelectedItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmActionsCreateRequest" /> class.
        /// </summary>
        /// <param name="filters">
        /// Filters to apply on tasks. You can use [the helper class `Filters` from this page](https://labelstud.io/sdk/data_manager.html) to create Data Manager Filters.Example: `{"conjunction": "or", "items": [{"filter": "filter:tasks:completed_at", "operator": "greater", "type": "Datetime", "value": "2021-01-01T00:00:00.000Z"}]}`
        /// </param>
        /// <param name="ordering">
        /// List of fields to order by. Fields are similar to filters but without the `filter:` prefix. To reverse the order, add a minus sign before the field name, e.g. `-tasks:created_at`.
        /// </param>
        /// <param name="selectedItems">
        /// Task selection by IDs. If filters are applied, the selection will be applied to the filtered tasks.If "all" is `false`, `"included"` must be used. If "all" is `true`, `"excluded"` must be used.Examples: `{"all": false, "included": [1, 2, 3]}` or `{"all": true, "excluded": [4, 5]}`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiDmActionsCreateRequest(
            global::G.ApiDmActionsCreateRequestFilters? filters,
            global::System.Collections.Generic.IList<global::G.ApiDmActionsCreateRequestOrderingItem>? ordering,
            global::G.OneOf<global::G.ApiDmActionsCreateRequestSelectedItemsAllFalse, global::G.ApiDmActionsCreateRequestSelectedItemsAllTrue>? selectedItems)
        {
            this.Filters = filters;
            this.Ordering = ordering;
            this.SelectedItems = selectedItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmActionsCreateRequest" /> class.
        /// </summary>
        public ApiDmActionsCreateRequest()
        {
        }
    }
}