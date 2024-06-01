//HintName: G.Models.OrgsListMembershipsForAuthenticatedUserState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgsListMembershipsForAuthenticatedUserState
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
    public static class OrgsListMembershipsForAuthenticatedUserStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsListMembershipsForAuthenticatedUserState value)
        {
            return value switch
            {
                OrgsListMembershipsForAuthenticatedUserState.Active => "active",
                OrgsListMembershipsForAuthenticatedUserState.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListMembershipsForAuthenticatedUserState ToEnum(string value)
        {
            return value switch
            {
                "active" => OrgsListMembershipsForAuthenticatedUserState.Active,
                "pending" => OrgsListMembershipsForAuthenticatedUserState.Pending,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}