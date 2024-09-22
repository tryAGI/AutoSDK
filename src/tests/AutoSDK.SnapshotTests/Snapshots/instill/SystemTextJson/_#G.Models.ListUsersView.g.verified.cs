//HintName: G.Models.ListUsersView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListUsersView
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
    public static class ListUsersViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListUsersView value)
        {
            return value switch
            {
                ListUsersView.VIEWBASIC => "VIEW_BASIC",
                ListUsersView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListUsersView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ListUsersView.VIEWBASIC,
                "VIEW_FULL" => ListUsersView.VIEWFULL,
                _ => null,
            };
        }
    }
}