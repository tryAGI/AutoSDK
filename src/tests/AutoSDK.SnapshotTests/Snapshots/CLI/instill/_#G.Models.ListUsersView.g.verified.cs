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
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        ViewFull,
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
                ListUsersView.ViewBasic => "VIEW_BASIC",
                ListUsersView.ViewFull => "VIEW_FULL",
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
                "VIEW_BASIC" => ListUsersView.ViewBasic,
                "VIEW_FULL" => ListUsersView.ViewFull,
                _ => null,
            };
        }
    }
}