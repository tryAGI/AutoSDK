//HintName: G.Models.DropsEntitlementUpdatedStatus.g.cs

#nullable enable

namespace G
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
    public abstract class DropsEntitlementUpdatedStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string INVALIDID = "INVALID_ID";
        /// <summary>
        /// 
        /// </summary>
        public const string NOTFOUND = "NOT_FOUND";
        /// <summary>
        /// 
        /// </summary>
        public const string SUCCESS = "SUCCESS";
        /// <summary>
        /// 
        /// </summary>
        public const string UNAUTHORIZED = "UNAUTHORIZED";
        /// <summary>
        /// 
        /// </summary>
        public const string UPDATEFAILED = "UPDATE_FAILED";
    }
}