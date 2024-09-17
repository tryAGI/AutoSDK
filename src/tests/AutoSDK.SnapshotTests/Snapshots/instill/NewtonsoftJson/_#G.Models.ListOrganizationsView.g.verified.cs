//HintName: G.Models.ListOrganizationsView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListOrganizationsView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_BASIC")]
        VIEWBASIC,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
        VIEWFULL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListOrganizationsViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListOrganizationsView value)
        {
            return value switch
            {
                ListOrganizationsView.VIEWBASIC => "VIEW_BASIC",
                ListOrganizationsView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListOrganizationsView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ListOrganizationsView.VIEWBASIC,
                "VIEW_FULL" => ListOrganizationsView.VIEWFULL,
                _ => null,
            };
        }
    }
}