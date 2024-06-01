//HintName: G.Models.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permission to grant to the team for this project. Default: the team's `permission` attribute will be used to determine what permission to grant the team on this project. Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling this endpoint. For more information, see "[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method)."
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamsAddOrUpdateProjectPermissionsLegacyRequestPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission value)
        {
            return value switch
            {
                TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission.Read => "read",
                TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission.Write => "write",
                TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission ToEnum(string value)
        {
            return value switch
            {
                "read" => TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission.Read,
                "write" => TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission.Write,
                "admin" => TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission.Admin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}