//HintName: G.Models.EntitiesListResponseItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EntitiesListResponseItemType
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
    public static class EntitiesListResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntitiesListResponseItemType value)
        {
            return value switch
            {
                EntitiesListResponseItemType.Agent => "agent",
                EntitiesListResponseItemType.App => "app",
                EntitiesListResponseItemType.Run => "run",
                EntitiesListResponseItemType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntitiesListResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => EntitiesListResponseItemType.Agent,
                "app" => EntitiesListResponseItemType.App,
                "run" => EntitiesListResponseItemType.Run,
                "user" => EntitiesListResponseItemType.User,
                _ => null,
            };
        }
    }
}