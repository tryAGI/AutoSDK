//HintName: G.Models.GetOrganizationMembershipView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetOrganizationMembershipView
    {
        /// <summary>
        /// Default view, only includes basic information.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_BASIC")]
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
        ViewFull,
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
                GetOrganizationMembershipView.ViewBasic => "VIEW_BASIC",
                GetOrganizationMembershipView.ViewFull => "VIEW_FULL",
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
                "VIEW_BASIC" => GetOrganizationMembershipView.ViewBasic,
                "VIEW_FULL" => GetOrganizationMembershipView.ViewFull,
                _ => null,
            };
        }
    }
}