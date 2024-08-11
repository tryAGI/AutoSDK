//HintName: G.Models.MigrationsGetStatusForOrgExcludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allowed values that can be passed to the exclude param.<br/>
    /// Example: repositories
    /// </summary>
    public enum MigrationsGetStatusForOrgExcludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Repositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MigrationsGetStatusForOrgExcludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MigrationsGetStatusForOrgExcludeItem value)
        {
            return value switch
            {
                MigrationsGetStatusForOrgExcludeItem.Repositories => "repositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MigrationsGetStatusForOrgExcludeItem? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => MigrationsGetStatusForOrgExcludeItem.Repositories,
                _ => null,
            };
        }
    }
}