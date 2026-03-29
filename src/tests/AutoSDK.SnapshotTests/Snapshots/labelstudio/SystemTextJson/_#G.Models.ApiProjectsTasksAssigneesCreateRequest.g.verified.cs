//HintName: G.Models.ApiProjectsTasksAssigneesCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsTasksAssigneesCreateRequest
    {
        /// <summary>
        /// Filters to apply on tasks. You can use [the helper class `Filters` from this page](https://labelstud.io/sdk/data_manager.html) to create Data Manager Filters.Example: `{"conjunction": "or", "items": [{"filter": "filter:tasks:completed_at", "operator": "greater", "type": "Datetime", "value": "2021-01-01T00:00:00.000Z"}]}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::G.ApiProjectsTasksAssigneesCreateRequestFilters? Filters { get; set; }

        /// <summary>
        /// Task selection by IDs. If filters are applied, the selection will be applied to the filtered tasks.If "all" is `false`, `"included"` must be used. If "all" is `true`, `"excluded"` must be used.Examples: `{"all": false, "included": [1, 2, 3]}` or `{"all": true, "excluded": [4, 5]}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectedItems")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse, global::G.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse, global::G.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue> SelectedItems { get; set; }

        /// <summary>
        /// Assignment type. Use AN for annotate or RE for review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiProjectsTasksAssigneesCreateRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiProjectsTasksAssigneesCreateRequestType Type { get; set; }

        /// <summary>
        /// List of user IDs to assign
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsTasksAssigneesCreateRequest" /> class.
        /// </summary>
        /// <param name="selectedItems">
        /// Task selection by IDs. If filters are applied, the selection will be applied to the filtered tasks.If "all" is `false`, `"included"` must be used. If "all" is `true`, `"excluded"` must be used.Examples: `{"all": false, "included": [1, 2, 3]}` or `{"all": true, "excluded": [4, 5]}`
        /// </param>
        /// <param name="type">
        /// Assignment type. Use AN for annotate or RE for review.
        /// </param>
        /// <param name="users">
        /// List of user IDs to assign
        /// </param>
        /// <param name="filters">
        /// Filters to apply on tasks. You can use [the helper class `Filters` from this page](https://labelstud.io/sdk/data_manager.html) to create Data Manager Filters.Example: `{"conjunction": "or", "items": [{"filter": "filter:tasks:completed_at", "operator": "greater", "type": "Datetime", "value": "2021-01-01T00:00:00.000Z"}]}`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsTasksAssigneesCreateRequest(
            global::G.OneOf<global::G.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse, global::G.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue> selectedItems,
            global::G.ApiProjectsTasksAssigneesCreateRequestType type,
            global::System.Collections.Generic.IList<int> users,
            global::G.ApiProjectsTasksAssigneesCreateRequestFilters? filters)
        {
            this.Filters = filters;
            this.SelectedItems = selectedItems;
            this.Type = type;
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsTasksAssigneesCreateRequest" /> class.
        /// </summary>
        public ApiProjectsTasksAssigneesCreateRequest()
        {
        }
    }
}