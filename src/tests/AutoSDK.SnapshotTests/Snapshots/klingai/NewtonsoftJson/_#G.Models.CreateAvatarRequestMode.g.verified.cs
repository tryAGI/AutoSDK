//HintName: G.Models.CreateAvatarRequestMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generation mode.<br/>
    /// Default Value: std
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAvatarRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pro")]
        Pro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="std")]
        Std,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAvatarRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarRequestMode value)
        {
            return value switch
            {
                CreateAvatarRequestMode.Pro => "pro",
                CreateAvatarRequestMode.Std => "std",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "pro" => CreateAvatarRequestMode.Pro,
                "std" => CreateAvatarRequestMode.Std,
                _ => null,
            };
        }
    }
}