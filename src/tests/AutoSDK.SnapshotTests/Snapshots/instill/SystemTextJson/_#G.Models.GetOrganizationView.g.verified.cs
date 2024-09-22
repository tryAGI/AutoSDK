//HintName: G.Models.GetOrganizationView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationView
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
    public static class GetOrganizationViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationView value)
        {
            return value switch
            {
                GetOrganizationView.VIEWBASIC => "VIEW_BASIC",
                GetOrganizationView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => GetOrganizationView.VIEWBASIC,
                "VIEW_FULL" => GetOrganizationView.VIEWFULL,
                _ => null,
            };
        }
    }
}