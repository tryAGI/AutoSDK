//HintName: G.Models.CreateMessageApiRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 已TODO 字段打平
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateMessageApiRequestRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMessageApiRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMessageApiRequestRole value)
        {
            return value switch
            {
                CreateMessageApiRequestRole.Assistant => "assistant",
                CreateMessageApiRequestRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMessageApiRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => CreateMessageApiRequestRole.Assistant,
                "user" => CreateMessageApiRequestRole.User,
                _ => null,
            };
        }
    }
}