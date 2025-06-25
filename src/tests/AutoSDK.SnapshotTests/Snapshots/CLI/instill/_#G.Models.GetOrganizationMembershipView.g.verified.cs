//HintName: G.Models.GetOrganizationMembershipView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationMembershipView
    {
        /// <summary>
        /// Default view, only includes basic information.
        /// </summary>
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        VIEWFULL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationMembershipViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationMembershipView value)
        {
            return value switch
            {
                GetOrganizationMembershipView.VIEWBASIC => "VIEW_BASIC",
                GetOrganizationMembershipView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationMembershipView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => GetOrganizationMembershipView.VIEWBASIC,
                "VIEW_FULL" => GetOrganizationMembershipView.VIEWFULL,
                _ => null,
            };
        }
    }
}