//HintName: G.Models.UserExtensionTypeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserExtensionTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Component,
        /// <summary>
        /// 
        /// </summary>
        Mobile,
        /// <summary>
        /// 
        /// </summary>
        Overlay,
        /// <summary>
        /// 
        /// </summary>
        Panel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserExtensionTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserExtensionTypeItem value)
        {
            return value switch
            {
                UserExtensionTypeItem.Component => "component",
                UserExtensionTypeItem.Mobile => "mobile",
                UserExtensionTypeItem.Overlay => "overlay",
                UserExtensionTypeItem.Panel => "panel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserExtensionTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "component" => UserExtensionTypeItem.Component,
                "mobile" => UserExtensionTypeItem.Mobile,
                "overlay" => UserExtensionTypeItem.Overlay,
                "panel" => UserExtensionTypeItem.Panel,
                _ => null,
            };
        }
    }
}