//HintName: G.Models.EntityInputEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the entity
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EntityInputEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent")]
        Agent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="app")]
        App,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run")]
        Run,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntityInputEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityInputEntityType value)
        {
            return value switch
            {
                EntityInputEntityType.Agent => "agent",
                EntityInputEntityType.App => "app",
                EntityInputEntityType.Run => "run",
                EntityInputEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityInputEntityType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => EntityInputEntityType.Agent,
                "app" => EntityInputEntityType.App,
                "run" => EntityInputEntityType.Run,
                "user" => EntityInputEntityType.User,
                _ => null,
            };
        }
    }
}