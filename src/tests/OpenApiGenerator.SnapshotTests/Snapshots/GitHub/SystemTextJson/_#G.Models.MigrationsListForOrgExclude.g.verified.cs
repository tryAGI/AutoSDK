//HintName: G.Models.MigrationsListForOrgExclude.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MigrationsListForOrgExclude
    {
        /// <summary>
        /// 
        /// </summary>
        Repositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MigrationsListForOrgExcludeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MigrationsListForOrgExclude value)
        {
            return value switch
            {
                MigrationsListForOrgExclude.Repositories => "repositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MigrationsListForOrgExclude? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => MigrationsListForOrgExclude.Repositories,
                _ => null,
            };
        }
    }
}