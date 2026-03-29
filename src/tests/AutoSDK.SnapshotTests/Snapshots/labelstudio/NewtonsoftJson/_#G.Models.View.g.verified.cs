//HintName: G.Models.View.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class View
    {
        /// <summary>
        /// Custom view data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public object? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_group")]
        public global::G.FilterGroup? FilterGroup { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

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
        /// Project ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public int Project { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="View" /> class.
        /// </summary>
        /// <param name="project">
        /// Project ID
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
        /// <param name="id">
        /// Included only in responses
        /// </param>
        public View(
            int project,
            object? data,
            global::G.FilterGroup? filterGroup,
            int? order,
            object? ordering,
            object? selectedItems,
            int? user,
            int id = default!)
        {
            this.Data = data;
            this.FilterGroup = filterGroup;
            this.Id = id;
            this.Order = order;
            this.Ordering = ordering;
            this.Project = project;
            this.SelectedItems = selectedItems;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="View" /> class.
        /// </summary>
        public View()
        {
        }
    }
}