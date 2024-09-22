//HintName: G.Models.View.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// View defines how a resource is presented. It can be used as a parameter in a<br/>
    /// method request to allow clients to select the amount of information they<br/>
    /// want in the response.<br/>
    ///  - VIEW_BASIC: Default view, only includes basic information.<br/>
    ///  - VIEW_FULL: Full representation.
    /// </summary>
    public enum View
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
    public static class ViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this View value)
        {
            return value switch
            {
                View.VIEWBASIC => "VIEW_BASIC",
                View.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static View? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => View.VIEWBASIC,
                "VIEW_FULL" => View.VIEWFULL,
                _ => null,
            };
        }
    }
}