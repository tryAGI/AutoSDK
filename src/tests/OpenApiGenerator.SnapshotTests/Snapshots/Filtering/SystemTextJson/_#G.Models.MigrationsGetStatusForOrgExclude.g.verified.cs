//HintName: G.Models.MigrationsGetStatusForOrgExclude.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MigrationsGetStatusForOrgExclude
    {
        /// <summary>
        /// 
        /// </summary>
        Repositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MigrationsGetStatusForOrgExcludeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MigrationsGetStatusForOrgExclude value)
        {
            return value switch
            {
                MigrationsGetStatusForOrgExclude.Repositories => "repositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MigrationsGetStatusForOrgExclude? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => MigrationsGetStatusForOrgExclude.Repositories,
                _ => null,
            };
        }
    }
}