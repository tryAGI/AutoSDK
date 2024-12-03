//HintName: G.Models.AppPermissionsOrganizationAnnouncementBanners.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to view and manage announcement banners for an organization.
    /// </summary>
    public enum AppPermissionsOrganizationAnnouncementBanners
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsOrganizationAnnouncementBannersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationAnnouncementBanners value)
        {
            return value switch
            {
                AppPermissionsOrganizationAnnouncementBanners.Read => "read",
                AppPermissionsOrganizationAnnouncementBanners.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationAnnouncementBanners? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationAnnouncementBanners.Read,
                "write" => AppPermissionsOrganizationAnnouncementBanners.Write,
                _ => null,
            };
        }
    }
}