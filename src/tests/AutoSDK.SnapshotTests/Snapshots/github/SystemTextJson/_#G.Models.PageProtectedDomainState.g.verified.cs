//HintName: G.Models.PageProtectedDomainState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state if the domain is verified<br/>
    /// Example: pending
    /// </summary>
    public enum PageProtectedDomainState
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Unverified,
        /// <summary>
        /// 
        /// </summary>
        Verified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PageProtectedDomainStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PageProtectedDomainState value)
        {
            return value switch
            {
                PageProtectedDomainState.Pending => "pending",
                PageProtectedDomainState.Unverified => "unverified",
                PageProtectedDomainState.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PageProtectedDomainState? ToEnum(string value)
        {
            return value switch
            {
                "pending" => PageProtectedDomainState.Pending,
                "unverified" => PageProtectedDomainState.Unverified,
                "verified" => PageProtectedDomainState.Verified,
                _ => null,
            };
        }
    }
}