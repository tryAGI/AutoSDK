//HintName: G.Models.ListOrganizationsView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListOrganizationsView
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
    public static class ListOrganizationsViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListOrganizationsView value)
        {
            return value switch
            {
                ListOrganizationsView.ViewBasic => "VIEW_BASIC",
                ListOrganizationsView.ViewFull => "VIEW_FULL",
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
                "VIEW_BASIC" => ListOrganizationsView.ViewBasic,
                "VIEW_FULL" => ListOrganizationsView.ViewFull,
                _ => null,
            };
        }
    }
}