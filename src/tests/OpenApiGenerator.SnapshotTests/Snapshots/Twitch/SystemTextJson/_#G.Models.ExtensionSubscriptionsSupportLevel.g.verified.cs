//HintName: G.Models.ExtensionSubscriptionsSupportLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates whether the extension can view the user’s subscription level on the channel that the extension is installed on. Possible values are:  
    ///   
    /// * none — The extension can't view the user’s subscription level.
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

    public static class ExtensionSubscriptionsSupportLevelExtensions
    {
        public static string ToValueString(this ExtensionSubscriptionsSupportLevel value)
        {
            return value switch
            {
                ExtensionSubscriptionsSupportLevel.None => "none",
                ExtensionSubscriptionsSupportLevel.Optional => "optional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionSubscriptionsSupportLevel ToEnum(string value)
        {
            return value switch
            {
                "none" => ExtensionSubscriptionsSupportLevel.None,
                "optional" => ExtensionSubscriptionsSupportLevel.Optional,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionSubscriptionsSupportLevel ToEnum(int value)
        {
            return value switch
            {
                0 => ExtensionSubscriptionsSupportLevel.None,
                1 => ExtensionSubscriptionsSupportLevel.Optional,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}