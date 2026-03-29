//HintName: G.Models.ScrapeResponseDataChangeTrackingVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The visibility of the current page/URL. 'visible' means the URL was discovered through an organic route (links or sitemap), 'hidden' means the URL was discovered through memory from previous crawls.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScrapeResponseDataChangeTrackingVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hidden")]
        Hidden,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="visible")]
        Visible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeResponseDataChangeTrackingVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeResponseDataChangeTrackingVisibility value)
        {
            return value switch
            {
                ScrapeResponseDataChangeTrackingVisibility.Hidden => "hidden",
                ScrapeResponseDataChangeTrackingVisibility.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeResponseDataChangeTrackingVisibility? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => ScrapeResponseDataChangeTrackingVisibility.Hidden,
                "visible" => ScrapeResponseDataChangeTrackingVisibility.Visible,
                _ => null,
            };
        }
    }
}