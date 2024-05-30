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
    [global::System.Runtime.Serialization.DataContract]
    public enum DropsEntitlementUpdatedStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INVALID_ID")]
        INVALIDID,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NOT_FOUND")]
        NOTFOUND,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        SUCCESS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNAUTHORIZED")]
        UNAUTHORIZED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UPDATE_FAILED")]
        UPDATEFAILED,
    }

    public static class DropsEntitlementUpdatedStatusExtensions
    {
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
        public static DropsEntitlementUpdatedStatus ToEnum(int value)
        {
            return value switch
            {
                0 => DropsEntitlementUpdatedStatus.INVALIDID,
                1 => DropsEntitlementUpdatedStatus.NOTFOUND,
                2 => DropsEntitlementUpdatedStatus.SUCCESS,
                3 => DropsEntitlementUpdatedStatus.UNAUTHORIZED,
                4 => DropsEntitlementUpdatedStatus.UPDATEFAILED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}