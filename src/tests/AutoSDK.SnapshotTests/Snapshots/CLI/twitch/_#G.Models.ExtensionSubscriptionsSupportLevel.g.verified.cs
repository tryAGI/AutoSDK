﻿//HintName: G.Models.ExtensionSubscriptionsSupportLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates whether the extension can view the user’s subscription level on the channel that the extension is installed on. Possible values are:  <br/>
    ///   <br/>
    /// * none — The extension can't view the user’s subscription level.<br/>
    /// * optional — The extension can view the user’s subscription level.
    /// </summary>
    public enum ExtensionSubscriptionsSupportLevel
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Optional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtensionSubscriptionsSupportLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtensionSubscriptionsSupportLevel value)
        {
            return value switch
            {
                ExtensionSubscriptionsSupportLevel.None => "none",
                ExtensionSubscriptionsSupportLevel.Optional => "optional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtensionSubscriptionsSupportLevel? ToEnum(string value)
        {
            return value switch
            {
                "none" => ExtensionSubscriptionsSupportLevel.None,
                "optional" => ExtensionSubscriptionsSupportLevel.Optional,
                _ => null,
            };
        }
    }
}