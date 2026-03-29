//HintName: G.Models.CreateAPIKeyRequestKeyPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAPIKeyRequestKeyPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="r")]
        R,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rw")]
        Rw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="w")]
        W,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAPIKeyRequestKeyPermissionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAPIKeyRequestKeyPermissions value)
        {
            return value switch
            {
                CreateAPIKeyRequestKeyPermissions.R => "r",
                CreateAPIKeyRequestKeyPermissions.Rw => "rw",
                CreateAPIKeyRequestKeyPermissions.W => "w",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAPIKeyRequestKeyPermissions? ToEnum(string value)
        {
            return value switch
            {
                "r" => CreateAPIKeyRequestKeyPermissions.R,
                "rw" => CreateAPIKeyRequestKeyPermissions.Rw,
                "w" => CreateAPIKeyRequestKeyPermissions.W,
                _ => null,
            };
        }
    }
}