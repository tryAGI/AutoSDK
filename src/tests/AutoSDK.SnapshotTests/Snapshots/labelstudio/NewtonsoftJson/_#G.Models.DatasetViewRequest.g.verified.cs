//HintName: G.Models.DatasetViewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetViewRequest
    {
        /// <summary>
        /// Custom view data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Dataset ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset", Required = global::Newtonsoft.Json.Required.Always)]
        public int Dataset { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_group")]
        public global::G.FilterGroupRequest? FilterGroup { get; set; }

        /// <summary>
        /// Position of the tab, starting at the left in data manager and increasing as the tabs go left to right
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Ordering parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ordering")]
        public object? Ordering { get; set; }

        /// <summary>
        /// Selected items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_items")]
        public object? SelectedItems { get; set; }

        /// <summary>
        /// User who made this view
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public int? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetViewRequest" /> class.
        /// </summary>
        /// <param name="dataset">
        /// Dataset ID
        /// </param>
        /// <param name="data">
        /// Custom view data
        /// </param>
        /// <param name="filterGroup"></param>
        /// <param name="order">
        /// Position of the tab, starting at the left in data manager and increasing as the tabs go left to right
        /// </param>
        /// <param name="ordering">
        /// Ordering parameters
        /// </param>
        /// <param name="selectedItems">
        /// Selected items
        /// </param>
        /// <param name="user">
        /// User who made this view
        /// </param>
        public DatasetViewRequest(
            int dataset,
            object? data,
            global::G.FilterGroupRequest? filterGroup,
            int? order,
            object? ordering,
            object? selectedItems,
            int? user)
        {
            this.Data = data;
            this.Dataset = dataset;
            this.FilterGroup = filterGroup;
            this.Order = order;
            this.Ordering = ordering;
            this.SelectedItems = selectedItems;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetViewRequest" /> class.
        /// </summary>
        public DatasetViewRequest()
        {
        }
    }
}