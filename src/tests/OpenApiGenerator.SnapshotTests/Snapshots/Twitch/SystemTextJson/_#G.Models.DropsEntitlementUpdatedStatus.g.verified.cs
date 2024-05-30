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
    public enum DropsEntitlementUpdatedStatus
    {
        /// <summary>
        /// 
        /// </summary>
        INVALIDID,
        /// <summary>
        /// 
        /// </summary>
        NOTFOUND,
        /// <summary>
        /// 
        /// </summary>
        SUCCESS,
        /// <summary>
        /// 
        /// </summary>
        UNAUTHORIZED,
        /// <summary>
        /// 
        /// </summary>
        UPDATEFAILED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DropsEntitlementUpdatedStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DropsEntitlementUpdatedStatus value)
        {
            return value switch
            {
                DropsEntitlementUpdatedStatus.INVALIDID => "INVALID_ID",
                DropsEntitlementUpdatedStatus.NOTFOUND => "NOT_FOUND",
                DropsEntitlementUpdatedStatus.SUCCESS => "SUCCESS",
                DropsEntitlementUpdatedStatus.UNAUTHORIZED => "UNAUTHORIZED",
                DropsEntitlementUpdatedStatus.UPDATEFAILED => "UPDATE_FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DropsEntitlementUpdatedStatus ToEnum(string value)
        {
            return value switch
            {
                "INVALID_ID" => DropsEntitlementUpdatedStatus.INVALIDID,
                "NOT_FOUND" => DropsEntitlementUpdatedStatus.NOTFOUND,
                "SUCCESS" => DropsEntitlementUpdatedStatus.SUCCESS,
                "UNAUTHORIZED" => DropsEntitlementUpdatedStatus.UNAUTHORIZED,
                "UPDATE_FAILED" => DropsEntitlementUpdatedStatus.UPDATEFAILED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}