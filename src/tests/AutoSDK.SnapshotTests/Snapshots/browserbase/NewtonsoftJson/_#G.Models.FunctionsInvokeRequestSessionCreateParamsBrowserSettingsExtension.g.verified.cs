//HintName: G.Models.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="browser-events")]
        BrowserEvents,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="onepassword")]
        Onepassword,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension value)
        {
            return value switch
            {
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension.BrowserEvents => "browser-events",
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension.Onepassword => "onepassword",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension? ToEnum(string value)
        {
            return value switch
            {
                "browser-events" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension.BrowserEvents,
                "onepassword" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension.Onepassword,
                _ => null,
            };
        }
    }
}