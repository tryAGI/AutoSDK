//HintName: G.Models.OrgMembershipState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the member in the organization. The `pending` state indicates the user has not yet accepted an invitation.<br/>
    /// Example: active
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgMembershipState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgMembershipStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgMembershipState value)
        {
            return value switch
            {
                OrgMembershipState.Active => "active",
                OrgMembershipState.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgMembershipState? ToEnum(string value)
        {
            return value switch
            {
                "active" => OrgMembershipState.Active,
                "pending" => OrgMembershipState.Pending,
                _ => null,
            };
        }
    }
}