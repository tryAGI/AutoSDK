//HintName: G.Models.ApiDmViewsCreateRequestDataFilters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filters to apply on tasks. You can use [the helper class `Filters` from this page](https://labelstud.io/sdk/data_manager.html) to create Data Manager Filters.Example: `{"conjunction": "or", "items": [{"filter": "filter:tasks:completed_at", "operator": "greater", "type": "Datetime", "value": "2021-01-01T00:00:00.000Z"}]}`
    /// </summary>
    public sealed partial class ApiDmViewsCreateRequestDataFilters
    {
        /// <summary>
        /// Logical conjunction for the filters. This conjunction (either "or" or "and") will be applied to all items in the filters list. It is not possible to combine "or" and "and" within one list of filters. All filters will be either combined with "or" or with "and", but not a mix of both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conjunction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiDmViewsCreateRequestDataFiltersConjunctionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiDmViewsCreateRequestDataFiltersConjunction Conjunction { get; set; }

        /// <summary>
        /// List of filter items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ApiDmViewsCreateRequestDataFiltersItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmViewsCreateRequestDataFilters" /> class.
        /// </summary>
        /// <param name="conjunction">
        /// Logical conjunction for the filters. This conjunction (either "or" or "and") will be applied to all items in the filters list. It is not possible to combine "or" and "and" within one list of filters. All filters will be either combined with "or" or with "and", but not a mix of both.
        /// </param>
        /// <param name="items">
        /// List of filter items
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiDmViewsCreateRequestDataFilters(
            global::G.ApiDmViewsCreateRequestDataFiltersConjunction conjunction,
            global::System.Collections.Generic.IList<global::G.ApiDmViewsCreateRequestDataFiltersItem> items)
        {
            this.Conjunction = conjunction;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmViewsCreateRequestDataFilters" /> class.
        /// </summary>
        public ApiDmViewsCreateRequestDataFilters()
        {
        }
    }
}