//HintName: G.Models.AnalyticsView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for user-scoped analytics saved views.<br/>
    /// The primary key is intentionally excluded; the ``uuid`` field is the only<br/>
    /// stable public identifier exposed to callers.<br/>
    /// ``dashboard_type`` scopes views per dashboard: "overview" vs "member_performance".
    /// </summary>
    public sealed partial class AnalyticsView
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// * `overview` - Overview<br/>
        /// * `member_performance` - Member Performance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dashboard_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DashboardTypeEnumJsonConverter))]
        public global::G.DashboardTypeEnum? DashboardType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public object? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("owner_id")]
        public int OwnerId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("uuid")]
        public global::System.Guid Uuid { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsView" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dashboardType">
        /// * `overview` - Overview<br/>
        /// * `member_performance` - Member Performance
        /// </param>
        /// <param name="filters"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="ownerId">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="uuid">
        /// Included only in responses
        /// </param>
        public AnalyticsView(
            string name,
            global::G.DashboardTypeEnum? dashboardType,
            object? filters,
            global::System.DateTime createdAt = default!,
            int ownerId = default!,
            global::System.DateTime updatedAt = default!,
            global::System.Guid uuid = default!)
        {
            this.CreatedAt = createdAt;
            this.DashboardType = dashboardType;
            this.Filters = filters;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OwnerId = ownerId;
            this.UpdatedAt = updatedAt;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsView" /> class.
        /// </summary>
        public AnalyticsView()
        {
        }
    }
}