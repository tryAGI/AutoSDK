//HintName: G.Models.MigrationsStartForAuthenticatedUserRequestExclude.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allowed values that can be passed to the exclude param.
    /// <br/>Example: repositories
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MigrationsStartForAuthenticatedUserRequestExclude
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repositories")]
        Repositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MigrationsStartForAuthenticatedUserRequestExcludeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MigrationsStartForAuthenticatedUserRequestExclude value)
        {
            return value switch
            {
                MigrationsStartForAuthenticatedUserRequestExclude.Repositories => "repositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MigrationsStartForAuthenticatedUserRequestExclude ToEnum(string value)
        {
            return value switch
            {
                "repositories" => MigrationsStartForAuthenticatedUserRequestExclude.Repositories,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}