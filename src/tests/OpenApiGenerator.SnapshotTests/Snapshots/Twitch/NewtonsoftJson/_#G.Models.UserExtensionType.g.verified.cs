//HintName: G.Models.UserExtensionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UserExtensionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="component")]
        Component,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mobile")]
        Mobile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="overlay")]
        Overlay,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="panel")]
        Panel,
    }

    public static class UserExtensionTypeExtensions
    {
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
        public static UserExtensionType ToEnum(string value)
        {
            return value switch
            {
                "component" => UserExtensionType.Component,
                "mobile" => UserExtensionType.Mobile,
                "overlay" => UserExtensionType.Overlay,
                "panel" => UserExtensionType.Panel,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UserExtensionType ToEnum(int value)
        {
            return value switch
            {
                0 => UserExtensionType.Component,
                1 => UserExtensionType.Mobile,
                2 => UserExtensionType.Overlay,
                3 => UserExtensionType.Panel,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}