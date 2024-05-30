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

    public static class MigrationsListForOrgExcludeExtensions
    {
        public static string ToValueString(this MigrationsListForOrgExclude value)
        {
            return value switch
            {
                MigrationsListForOrgExclude.Repositories => "repositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MigrationsListForOrgExclude ToEnum(string value)
        {
            return value switch
            {
                "repositories" => MigrationsListForOrgExclude.Repositories,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MigrationsListForOrgExclude ToEnum(int value)
        {
            return value switch
            {
                0 => MigrationsListForOrgExclude.Repositories,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}