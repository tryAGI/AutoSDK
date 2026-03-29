//HintName: G.Models.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// [NOT IN DOCS] Resource size of the browser.<br/>
    /// Default Value: small
    /// </summary>
    public enum FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize
    {
        /// <summary>
        /// 
        /// </summary>
        Large,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize value)
        {
            return value switch
            {
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.Large => "large",
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.Medium => "medium",
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize? ToEnum(string value)
        {
            return value switch
            {
                "large" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.Large,
                "medium" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.Medium,
                "small" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.Small,
                _ => null,
            };
        }
    }
}