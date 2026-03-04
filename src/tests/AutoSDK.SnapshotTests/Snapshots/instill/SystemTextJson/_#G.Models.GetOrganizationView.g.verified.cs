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
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        ViewFull,
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
                GetOrganizationView.ViewBasic => "VIEW_BASIC",
                GetOrganizationView.ViewFull => "VIEW_FULL",
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
                "VIEW_BASIC" => GetOrganizationView.ViewBasic,
                "VIEW_FULL" => GetOrganizationView.ViewFull,
                _ => null,
            };
        }
    }
}