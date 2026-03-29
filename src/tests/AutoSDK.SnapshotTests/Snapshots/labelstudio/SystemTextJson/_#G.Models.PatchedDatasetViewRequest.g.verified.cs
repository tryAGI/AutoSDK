//HintName: G.Models.PatchedDatasetViewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedDatasetViewRequest
    {
        /// <summary>
        /// Custom view data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Dataset ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        public int? Dataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_group")]
        public global::G.FilterGroupRequest? FilterGroup { get; set; }

        /// <summary>
        /// Position of the tab, starting at the left in data manager and increasing as the tabs go left to right
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Ordering parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordering")]
        public object? Ordering { get; set; }

        /// <summary>
        /// Selected items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_items")]
        public object? SelectedItems { get; set; }

        /// <summary>
        /// User who made this view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public int? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDatasetViewRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// Custom view data
        /// </param>
        /// <param name="dataset">
        /// Dataset ID
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedDatasetViewRequest(
            object? data,
            int? dataset,
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
        /// Initializes a new instance of the <see cref="PatchedDatasetViewRequest" /> class.
        /// </summary>
        public PatchedDatasetViewRequest()
        {
        }
    }
}