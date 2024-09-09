//HintName: G.Models.MigrationsListForOrgExcludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allowed values that can be passed to the exclude param.<br/>
    /// Example: repositories
    /// </summary>
    public enum MigrationsListForOrgExcludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Repositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MigrationsListForOrgExcludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MigrationsListForOrgExcludeItem value)
        {
            return value switch
            {
                MigrationsListForOrgExcludeItem.Repositories => "repositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MigrationsListForOrgExcludeItem? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => MigrationsListForOrgExcludeItem.Repositories,
                _ => null,
            };
        }
    }
}