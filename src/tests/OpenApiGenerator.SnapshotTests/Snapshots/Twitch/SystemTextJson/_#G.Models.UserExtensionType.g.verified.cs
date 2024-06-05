//HintName: G.Models.UserExtensionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserExtensionType
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
    public static class UserExtensionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserExtensionType value)
        {
            return value switch
            {
                UserExtensionType.Component => "component",
                UserExtensionType.Mobile => "mobile",
                UserExtensionType.Overlay => "overlay",
                UserExtensionType.Panel => "panel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserExtensionType? ToEnum(string value)
        {
            return value switch
            {
                "component" => UserExtensionType.Component,
                "mobile" => UserExtensionType.Mobile,
                "overlay" => UserExtensionType.Overlay,
                "panel" => UserExtensionType.Panel,
                _ => null,
            };
        }
    }
}