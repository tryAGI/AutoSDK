//HintName: G.Models.GetUserMembershipView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetUserMembershipView
    {
        /// <summary>
        /// 
        /// </summary>
        VIEWBASIC,
        /// <summary>
        /// 
        /// </summary>
        VIEWFULL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUserMembershipViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserMembershipView value)
        {
            return value switch
            {
                GetUserMembershipView.VIEWBASIC => "VIEW_BASIC",
                GetUserMembershipView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserMembershipView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => GetUserMembershipView.VIEWBASIC,
                "VIEW_FULL" => GetUserMembershipView.VIEWFULL,
                _ => null,
            };
        }
    }
}