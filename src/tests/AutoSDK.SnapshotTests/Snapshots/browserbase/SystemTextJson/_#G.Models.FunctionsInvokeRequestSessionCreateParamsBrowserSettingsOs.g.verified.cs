//HintName: G.Models.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operating system for stealth mode. Valid values: windows, mac, linux, mobile, tablet
    /// </summary>
    public enum FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs
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
    public static class FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs value)
        {
            return value switch
            {
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs.Linux => "linux",
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs.Mac => "mac",
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs.Mobile => "mobile",
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs.Tablet => "tablet",
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs.Windows => "windows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs? ToEnum(string value)
        {
            return value switch
            {
                "linux" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs.Linux,
                "mac" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs.Mac,
                "mobile" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs.Mobile,
                "tablet" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs.Tablet,
                "windows" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs.Windows,
                _ => null,
            };
        }
    }
}