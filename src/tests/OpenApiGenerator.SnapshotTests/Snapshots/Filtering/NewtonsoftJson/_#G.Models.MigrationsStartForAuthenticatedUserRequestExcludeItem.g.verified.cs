//HintName: G.Models.MigrationsStartForAuthenticatedUserRequestExcludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allowed values that can be passed to the exclude param.<br/>
    /// Example: repositories
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MigrationsStartForAuthenticatedUserRequestExcludeItem
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
    public static class MigrationsStartForAuthenticatedUserRequestExcludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MigrationsStartForAuthenticatedUserRequestExcludeItem value)
        {
            return value switch
            {
                MigrationsStartForAuthenticatedUserRequestExcludeItem.Repositories => "repositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MigrationsStartForAuthenticatedUserRequestExcludeItem? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => MigrationsStartForAuthenticatedUserRequestExcludeItem.Repositories,
                _ => null,
            };
        }
    }
}