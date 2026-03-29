//HintName: G.Models.EnvironmentsSendMessageRequestMessageVariant1Role.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnvironmentsSendMessageRequestMessageVariant1Role
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentsSendMessageRequestMessageVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentsSendMessageRequestMessageVariant1Role value)
        {
            return value switch
            {
                EnvironmentsSendMessageRequestMessageVariant1Role.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentsSendMessageRequestMessageVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "user" => EnvironmentsSendMessageRequestMessageVariant1Role.User,
                _ => null,
            };
        }
    }
}