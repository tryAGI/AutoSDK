//HintName: G.Models.TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permission to grant to the team for this project. Default: the team's `permission` attribute will be used to determine what permission to grant the team on this project. Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling this endpoint. For more information, see "[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method)."
    /// </summary>
    public enum TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
        /// <summary>
        /// 
        /// </summary>
        Admin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamsAddOrUpdateProjectPermissionsInOrgRequestPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission value)
        {
            return value switch
            {
                TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission.Read => "read",
                TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission.Write => "write",
                TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission ToEnum(string value)
        {
            return value switch
            {
                "read" => TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission.Read,
                "write" => TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission.Write,
                "admin" => TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission.Admin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}