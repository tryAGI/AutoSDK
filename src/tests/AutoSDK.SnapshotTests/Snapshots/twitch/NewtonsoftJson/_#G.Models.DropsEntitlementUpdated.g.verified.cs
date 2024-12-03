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
        /// A string that indicates whether the status of the entitlements in the `ids` field were successfully updated. Possible values are:  <br/>
        ///   <br/>
        /// * INVALID\_ID — The entitlement IDs in the `ids` field are not valid.<br/>
        /// * NOT\_FOUND — The entitlement IDs in the `ids` field were not found.<br/>
        /// * SUCCESS — The status of the entitlements in the `ids` field were successfully updated.<br/>
        /// * UNAUTHORIZED — The user or organization identified by the user access token is not authorized to update the entitlements.<br/>
        /// * UPDATE\_FAILED — The update failed. These are considered transient errors and the request should be retried later.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DropsEntitlementUpdatedStatus Status { get; set; } = default!;

        /// <summary>
        /// The list of entitlements that the status in the `status` field applies to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Ids { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DropsEntitlementUpdated" /> class.
        /// </summary>
        /// <param name="status">
        /// A string that indicates whether the status of the entitlements in the `ids` field were successfully updated. Possible values are:  <br/>
        ///   <br/>
        /// * INVALID\_ID — The entitlement IDs in the `ids` field are not valid.<br/>
        /// * NOT\_FOUND — The entitlement IDs in the `ids` field were not found.<br/>
        /// * SUCCESS — The status of the entitlements in the `ids` field were successfully updated.<br/>
        /// * UNAUTHORIZED — The user or organization identified by the user access token is not authorized to update the entitlements.<br/>
        /// * UPDATE\_FAILED — The update failed. These are considered transient errors and the request should be retried later.
        /// </param>
        /// <param name="ids">
        /// The list of entitlements that the status in the `status` field applies to.
        /// </param>
        public DropsEntitlementUpdated(
            global::G.DropsEntitlementUpdatedStatus status,
            global::System.Collections.Generic.IList<string> ids)
        {
            this.Status = status;
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DropsEntitlementUpdated" /> class.
        /// </summary>
        public DropsEntitlementUpdated()
        {
        }
    }
}