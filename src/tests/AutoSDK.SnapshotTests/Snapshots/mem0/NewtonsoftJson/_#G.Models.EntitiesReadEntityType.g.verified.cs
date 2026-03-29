//HintName: G.Models.EntitiesReadEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EntitiesReadEntityType
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
    public static class EntitiesReadEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntitiesReadEntityType value)
        {
            return value switch
            {
                EntitiesReadEntityType.Agent => "agent",
                EntitiesReadEntityType.App => "app",
                EntitiesReadEntityType.Run => "run",
                EntitiesReadEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntitiesReadEntityType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => EntitiesReadEntityType.Agent,
                "app" => EntitiesReadEntityType.App,
                "run" => EntitiesReadEntityType.Run,
                "user" => EntitiesReadEntityType.User,
                _ => null,
            };
        }
    }
}