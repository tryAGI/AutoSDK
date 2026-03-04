//HintName: G.Models.DropsEntitlementUpdatedStatus.g.cs

#nullable enable

namespace G
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
    public enum DropsEntitlementUpdatedStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidId,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        UpdateFailed,
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
                DropsEntitlementUpdatedStatus.InvalidId => "INVALID_ID",
                DropsEntitlementUpdatedStatus.NotFound => "NOT_FOUND",
                DropsEntitlementUpdatedStatus.Success => "SUCCESS",
                DropsEntitlementUpdatedStatus.Unauthorized => "UNAUTHORIZED",
                DropsEntitlementUpdatedStatus.UpdateFailed => "UPDATE_FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DropsEntitlementUpdatedStatus? ToEnum(string value)
        {
            return value switch
            {
                "INVALID_ID" => DropsEntitlementUpdatedStatus.InvalidId,
                "NOT_FOUND" => DropsEntitlementUpdatedStatus.NotFound,
                "SUCCESS" => DropsEntitlementUpdatedStatus.Success,
                "UNAUTHORIZED" => DropsEntitlementUpdatedStatus.Unauthorized,
                "UPDATE_FAILED" => DropsEntitlementUpdatedStatus.UpdateFailed,
                _ => null,
            };
        }
    }
}