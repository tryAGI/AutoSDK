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
        /// Default view, only includes basic information.
        /// </summary>
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        ViewFull,
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
                GetUserMembershipView.ViewBasic => "VIEW_BASIC",
                GetUserMembershipView.ViewFull => "VIEW_FULL",
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
                "VIEW_BASIC" => GetUserMembershipView.ViewBasic,
                "VIEW_FULL" => GetUserMembershipView.ViewFull,
                _ => null,
            };
        }
    }
}