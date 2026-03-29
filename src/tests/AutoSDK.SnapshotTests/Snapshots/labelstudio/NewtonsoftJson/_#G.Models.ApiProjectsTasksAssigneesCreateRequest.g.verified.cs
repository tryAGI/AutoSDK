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
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::G.ApiProjectsTasksAssigneesCreateRequestFilters? Filters { get; set; }

        /// <summary>
        /// Task selection by IDs. If filters are applied, the selection will be applied to the filtered tasks.If "all" is `false`, `"included"` must be used. If "all" is `true`, `"excluded"` must be used.Examples: `{"all": false, "included": [1, 2, 3]}` or `{"all": true, "excluded": [4, 5]}`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selectedItems", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse, global::G.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue> SelectedItems { get; set; } = default!;

        /// <summary>
        /// Assignment type. Use AN for annotate or RE for review.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiProjectsTasksAssigneesCreateRequestType Type { get; set; } = default!;

        /// <summary>
        /// List of user IDs to assign
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Users { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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