//HintName: G.Models.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operating system for stealth mode. Valid values: windows, mac, linux, mobile, tablet
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs
    {
        /// <summary>
        /// windows, mac, linux, mobile, tablet
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="linux")]
        Linux,
        /// <summary>
        /// windows, mac, linux, mobile, tablet
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mac")]
        Mac,
        /// <summary>
        /// windows, mac, linux, mobile, tablet
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mobile")]
        Mobile,
        /// <summary>
        /// windows, mac, linux, mobile, tablet
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tablet")]
        Tablet,
        /// <summary>
        /// windows, mac, linux, mobile, tablet
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="windows")]
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