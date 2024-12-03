//HintName: G.Models.RoleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RoleType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RoleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoleType value)
        {
            return value switch
            {
                RoleType.User => "user",
                RoleType.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoleType? ToEnum(string value)
        {
            return value switch
            {
                "user" => RoleType.User,
                "assistant" => RoleType.Assistant,
                _ => null,
            };
        }
    }
}