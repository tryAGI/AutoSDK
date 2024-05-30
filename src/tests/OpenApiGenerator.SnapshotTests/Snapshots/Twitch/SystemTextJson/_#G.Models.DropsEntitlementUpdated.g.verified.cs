//HintName: G.Models.DropsEntitlementUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DropsEntitlementUpdated
    {
        /// <summary>
        /// A string that indicates whether the status of the entitlements in the `ids` field were successfully updated. Possible values are:  
        ///   
        /// * INVALID\_ID — The entitlement IDs in the `ids` field are not valid.
        /// * NOT\_FOUND — The entitlement IDs in the `ids` field were not found.
        /// * SUCCESS — The status of the entitlements in the `ids` field were successfully updated.
        /// * UNAUTHORIZED — The user or organization identified by the user access token is not authorized to update the entitlements.
        /// * UPDATE\_FAILED — The update failed. These are considered transient errors and the request should be retried later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.DropsEntitlementUpdatedStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required DropsEntitlementUpdatedStatus Status { get; set; }

        /// <summary>
        /// The list of entitlements that the status in the `status` field applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}