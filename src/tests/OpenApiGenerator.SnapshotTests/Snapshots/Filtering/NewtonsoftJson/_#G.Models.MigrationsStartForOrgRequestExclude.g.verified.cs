//HintName: G.Models.MigrationsStartForOrgRequestExclude.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MigrationsStartForOrgRequestExclude
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repositories")]
        Repositories,
    }

    public static class MigrationsStartForOrgRequestExcludeExtensions
    {
        public static string ToValueString(this MigrationsStartForOrgRequestExclude value)
        {
            return value switch
            {
                MigrationsStartForOrgRequestExclude.Repositories => "repositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MigrationsStartForOrgRequestExclude ToEnum(string value)
        {
            return value switch
            {
                "repositories" => MigrationsStartForOrgRequestExclude.Repositories,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MigrationsStartForOrgRequestExclude ToEnum(int value)
        {
            return value switch
            {
                0 => MigrationsStartForOrgRequestExclude.Repositories,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}