//HintName: G.Models.GetAnalyticsGroupsUsersResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGroupsUsersResponseDataItem
    {
        /// <summary>
        /// The user for which the data is calculated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Total requests made by this user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public string? Requests { get; set; }

        /// <summary>
        /// Total cost in cents for the requests made by this user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public string? Cost { get; set; }

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectJsonConverter))]
        public global::G.GetAnalyticsGroupsUsersResponseDataItemObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsUsersResponseDataItem" /> class.
        /// </summary>
        /// <param name="user">
        /// The user for which the data is calculated
        /// </param>
        /// <param name="requests">
        /// Total requests made by this user
        /// </param>
        /// <param name="cost">
        /// Total cost in cents for the requests made by this user
        /// </param>
        /// <param name="object">
        /// The type of object being returned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGroupsUsersResponseDataItem(
            string? user,
            string? requests,
            string? cost,
            global::G.GetAnalyticsGroupsUsersResponseDataItemObject? @object)
        {
            this.User = user;
            this.Requests = requests;
            this.Cost = cost;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsUsersResponseDataItem" /> class.
        /// </summary>
        public GetAnalyticsGroupsUsersResponseDataItem()
        {
        }
    }
}