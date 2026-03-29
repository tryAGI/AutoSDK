//HintName: G.Models.SessionsCreateRequestBrowserSettingsOs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operating system for stealth mode. Valid values: windows, mac, linux, mobile, tablet
    /// </summary>
    public enum SessionsCreateRequestBrowserSettingsOs
    {
        /// <summary>
        /// windows, mac, linux, mobile, tablet
        /// </summary>
        Linux,
        /// <summary>
        /// windows, mac, linux, mobile, tablet
        /// </summary>
        Mac,
        /// <summary>
        /// windows, mac, linux, mobile, tablet
        /// </summary>
        Mobile,
        /// <summary>
        /// windows, mac, linux, mobile, tablet
        /// </summary>
        Tablet,
        /// <summary>
        /// windows, mac, linux, mobile, tablet
        /// </summary>
        Windows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionsCreateRequestBrowserSettingsOsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsCreateRequestBrowserSettingsOs value)
        {
            return value switch
            {
                SessionsCreateRequestBrowserSettingsOs.Linux => "linux",
                SessionsCreateRequestBrowserSettingsOs.Mac => "mac",
                SessionsCreateRequestBrowserSettingsOs.Mobile => "mobile",
                SessionsCreateRequestBrowserSettingsOs.Tablet => "tablet",
                SessionsCreateRequestBrowserSettingsOs.Windows => "windows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsCreateRequestBrowserSettingsOs? ToEnum(string value)
        {
            return value switch
            {
                "linux" => SessionsCreateRequestBrowserSettingsOs.Linux,
                "mac" => SessionsCreateRequestBrowserSettingsOs.Mac,
                "mobile" => SessionsCreateRequestBrowserSettingsOs.Mobile,
                "tablet" => SessionsCreateRequestBrowserSettingsOs.Tablet,
                "windows" => SessionsCreateRequestBrowserSettingsOs.Windows,
                _ => null,
            };
        }
    }
}