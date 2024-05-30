//HintName: G.Models.PageProtectedDomainState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state if the domain is verified
    /// <br/>Example: pending
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PageProtectedDomainState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="verified")]
        Verified,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unverified")]
        Unverified,
    }

    public static class PageProtectedDomainStateExtensions
    {
        public static string ToValueString(this PageProtectedDomainState value)
        {
            return value switch
            {
                PageProtectedDomainState.Pending => "pending",
                PageProtectedDomainState.Verified => "verified",
                PageProtectedDomainState.Unverified => "unverified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PageProtectedDomainState ToEnum(string value)
        {
            return value switch
            {
                "pending" => PageProtectedDomainState.Pending,
                "verified" => PageProtectedDomainState.Verified,
                "unverified" => PageProtectedDomainState.Unverified,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PageProtectedDomainState ToEnum(int value)
        {
            return value switch
            {
                0 => PageProtectedDomainState.Pending,
                1 => PageProtectedDomainState.Verified,
                2 => PageProtectedDomainState.Unverified,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}