//HintName: G.Models.ApiDmViewsPartialUpdateRequestDataFilters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filters to apply on tasks. You can use [the helper class `Filters` from this page](https://labelstud.io/sdk/data_manager.html) to create Data Manager Filters.Example: `{"conjunction": "or", "items": [{"filter": "filter:tasks:completed_at", "operator": "greater", "type": "Datetime", "value": "2021-01-01T00:00:00.000Z"}]}`
    /// </summary>
    public sealed partial class ApiDmViewsPartialUpdateRequestDataFilters
    {
        /// <summary>
        /// Logical conjunction for the filters. This conjunction (either "or" or "and") will be applied to all items in the filters list. It is not possible to combine "or" and "and" within one list of filters. All filters will be either combined with "or" or with "and", but not a mix of both.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conjunction", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersConjunctionJsonConverter))]
        public global::G.ApiDmViewsPartialUpdateRequestDataFiltersConjunction Conjunction { get; set; } = default!;

        /// <summary>
        /// List of filter items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ApiDmViewsPartialUpdateRequestDataFiltersItem> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmViewsPartialUpdateRequestDataFilters" /> class.
        /// </summary>
        /// <param name="conjunction">
        /// Logical conjunction for the filters. This conjunction (either "or" or "and") will be applied to all items in the filters list. It is not possible to combine "or" and "and" within one list of filters. All filters will be either combined with "or" or with "and", but not a mix of both.
        /// </param>
        /// <param name="items">
        /// List of filter items
        /// </param>
        public ApiDmViewsPartialUpdateRequestDataFilters(
            global::G.ApiDmViewsPartialUpdateRequestDataFiltersConjunction conjunction,
            global::System.Collections.Generic.IList<global::G.ApiDmViewsPartialUpdateRequestDataFiltersItem> items)
        {
            this.Conjunction = conjunction;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmViewsPartialUpdateRequestDataFilters" /> class.
        /// </summary>
        public ApiDmViewsPartialUpdateRequestDataFilters()
        {
        }
    }
}