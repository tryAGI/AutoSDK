//HintName: G.Models.EntitiesDeleteEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EntitiesDeleteEntityType
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
    public static class EntitiesDeleteEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntitiesDeleteEntityType value)
        {
            return value switch
            {
                EntitiesDeleteEntityType.Agent => "agent",
                EntitiesDeleteEntityType.App => "app",
                EntitiesDeleteEntityType.Run => "run",
                EntitiesDeleteEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntitiesDeleteEntityType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => EntitiesDeleteEntityType.Agent,
                "app" => EntitiesDeleteEntityType.App,
                "run" => EntitiesDeleteEntityType.Run,
                "user" => EntitiesDeleteEntityType.User,
                _ => null,
            };
        }
    }
}