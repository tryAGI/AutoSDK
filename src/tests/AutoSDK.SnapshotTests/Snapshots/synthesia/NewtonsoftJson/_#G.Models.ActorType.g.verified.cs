//HintName: G.Models.ActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Types of actors that can perform actions.<br/>
    /// USER: A human user (authenticated via username/password, social login, or SAML SSO)<br/>
    /// SYSTEM: An automated system process (e.g., "billing_system", "moderation_system")<br/>
    /// SERVICE: An internal service (e.g., "rendering_service", "dubbing_service")
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActorType
    {
        /// <summary>
        /// An internal service (e.g., "rendering_service", "dubbing_service")
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="service")]
        Service,
        /// <summary>
        /// An automated system process (e.g., "billing_system", "moderation_system")
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// A human user (authenticated via username/password, social login, or SAML SSO)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorType value)
        {
            return value switch
            {
                ActorType.Service => "service",
                ActorType.System => "system",
                ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorType? ToEnum(string value)
        {
            return value switch
            {
                "service" => ActorType.Service,
                "system" => ActorType.System,
                "user" => ActorType.User,
                _ => null,
            };
        }
    }
}