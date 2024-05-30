//HintName: G.Models.MigrationsStartForAuthenticatedUserRequestExclude.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allowed values that can be passed to the exclude param.
    /// <br/>Example: repositories
    /// </summary>
    public enum MigrationsStartForAuthenticatedUserRequestExclude
    {
        /// <summary>
        /// 
        /// </summary>
        Repositories,
    }

    public static class MigrationsStartForAuthenticatedUserRequestExcludeExtensions
    {
        public static string ToValueString(this MigrationsStartForAuthenticatedUserRequestExclude value)
        {
            return value switch
            {
                MigrationsStartForAuthenticatedUserRequestExclude.Repositories => "repositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MigrationsStartForAuthenticatedUserRequestExclude ToEnum(string value)
        {
            return value switch
            {
                "repositories" => MigrationsStartForAuthenticatedUserRequestExclude.Repositories,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MigrationsStartForAuthenticatedUserRequestExclude ToEnum(int value)
        {
            return value switch
            {
                0 => MigrationsStartForAuthenticatedUserRequestExclude.Repositories,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}