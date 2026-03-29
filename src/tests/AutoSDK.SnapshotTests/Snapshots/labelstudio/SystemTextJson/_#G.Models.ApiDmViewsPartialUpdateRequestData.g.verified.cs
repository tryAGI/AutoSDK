//HintName: G.Models.ApiDmViewsPartialUpdateRequestData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom view data
    /// </summary>
    public sealed partial class ApiDmViewsPartialUpdateRequestData
    {
        /// <summary>
        /// Filters to apply on tasks. You can use [the helper class `Filters` from this page](https://labelstud.io/sdk/data_manager.html) to create Data Manager Filters.Example: `{"conjunction": "or", "items": [{"filter": "filter:tasks:completed_at", "operator": "greater", "type": "Datetime", "value": "2021-01-01T00:00:00.000Z"}]}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::G.ApiDmViewsPartialUpdateRequestDataFilters? Filters { get; set; }

        /// <summary>
        /// List of fields to order by. Fields are similar to filters but without the `filter:` prefix. To reverse the order, add a minus sign before the field name, e.g. `-tasks:created_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordering")]
        public global::System.Collections.Generic.IList<global::G.ApiDmViewsPartialUpdateRequestDataOrderingItem>? Ordering { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmViewsPartialUpdateRequestData" /> class.
        /// </summary>
        /// <param name="filters">
        /// Filters to apply on tasks. You can use [the helper class `Filters` from this page](https://labelstud.io/sdk/data_manager.html) to create Data Manager Filters.Example: `{"conjunction": "or", "items": [{"filter": "filter:tasks:completed_at", "operator": "greater", "type": "Datetime", "value": "2021-01-01T00:00:00.000Z"}]}`
        /// </param>
        /// <param name="ordering">
        /// List of fields to order by. Fields are similar to filters but without the `filter:` prefix. To reverse the order, add a minus sign before the field name, e.g. `-tasks:created_at`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiDmViewsPartialUpdateRequestData(
            global::G.ApiDmViewsPartialUpdateRequestDataFilters? filters,
            global::System.Collections.Generic.IList<global::G.ApiDmViewsPartialUpdateRequestDataOrderingItem>? ordering)
        {
            this.Filters = filters;
            this.Ordering = ordering;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmViewsPartialUpdateRequestData" /> class.
        /// </summary>
        public ApiDmViewsPartialUpdateRequestData()
        {
        }
    }
}