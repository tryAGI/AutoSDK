//HintName: G.Models.EntityInputEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the entity
    /// </summary>
    public enum EntityInputEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Run,
        /// <summary>
        /// 
        /// </summary>
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