//HintName: G.Models.MigrationsStartForOrgRequestExcludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MigrationsStartForOrgRequestExcludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Repositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MigrationsStartForOrgRequestExcludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MigrationsStartForOrgRequestExcludeItem value)
        {
            return value switch
            {
                MigrationsStartForOrgRequestExcludeItem.Repositories => "repositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MigrationsStartForOrgRequestExcludeItem? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => MigrationsStartForOrgRequestExcludeItem.Repositories,
                _ => null,
            };
        }
    }
}