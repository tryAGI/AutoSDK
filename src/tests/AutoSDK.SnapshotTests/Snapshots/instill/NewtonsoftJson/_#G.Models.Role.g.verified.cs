//HintName: G.Models.Role.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Role describes the permissions a user has over a resource.<br/>
    ///  - ROLE_VIEWER: Viewers can see the resource properties.<br/>
    ///  - ROLE_EXECUTOR: Executors can execute the resource (e.g. trigger a pipeline).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Role
    {
        /// <summary>
        /// Executors can execute the resource (e.g. trigger a pipeline).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ROLE_EXECUTOR")]
        Executor,
        /// <summary>
        /// Viewers can see the resource properties.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ROLE_VIEWER")]
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Role value)
        {
            return value switch
            {
                Role.Executor => "ROLE_EXECUTOR",
                Role.Viewer => "ROLE_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Role? ToEnum(string value)
        {
            return value switch
            {
                "ROLE_EXECUTOR" => Role.Executor,
                "ROLE_VIEWER" => Role.Viewer,
                _ => null,
            };
        }
    }
}