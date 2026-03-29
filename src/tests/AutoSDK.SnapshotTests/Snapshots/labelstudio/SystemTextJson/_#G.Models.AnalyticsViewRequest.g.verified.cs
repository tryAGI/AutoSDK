//HintName: G.Models.AnalyticsViewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for user-scoped analytics saved views.<br/>
    /// The primary key is intentionally excluded; the ``uuid`` field is the only<br/>
    /// stable public identifier exposed to callers.<br/>
    /// ``dashboard_type`` scopes views per dashboard: "overview" vs "member_performance".
    /// </summary>
    public sealed partial class AnalyticsViewRequest
    {
        /// <summary>
        /// * `overview` - Overview<br/>
        /// * `member_performance` - Member Performance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashboard_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DashboardTypeEnumJsonConverter))]
        public global::G.DashboardTypeEnum? DashboardType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public object? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsViewRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dashboardType">
        /// * `overview` - Overview<br/>
        /// * `member_performance` - Member Performance
        /// </param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsViewRequest(
            string name,
            global::G.DashboardTypeEnum? dashboardType,
            object? filters)
        {
            this.DashboardType = dashboardType;
            this.Filters = filters;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsViewRequest" /> class.
        /// </summary>
        public AnalyticsViewRequest()
        {
        }
    }
}