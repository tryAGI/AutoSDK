//HintName: G.Models.MigrationsGetStatusForOrgExclude.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MigrationsGetStatusForOrgExclude
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repositories")]
        Repositories,
    }

    public static class MigrationsGetStatusForOrgExcludeExtensions
    {
        public static string ToValueString(this MigrationsGetStatusForOrgExclude value)
        {
            return value switch
            {
                MigrationsGetStatusForOrgExclude.Repositories => "repositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MigrationsGetStatusForOrgExclude ToEnum(string value)
        {
            return value switch
            {
                "repositories" => MigrationsGetStatusForOrgExclude.Repositories,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MigrationsGetStatusForOrgExclude ToEnum(int value)
        {
            return value switch
            {
                0 => MigrationsGetStatusForOrgExclude.Repositories,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}