//HintName: G.Models.GetUserMembershipView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetUserMembershipView
    {
        /// <summary>
        /// Default view, only includes basic information.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_BASIC")]
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
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