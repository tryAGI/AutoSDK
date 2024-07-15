//HintName: G.Models.AppPermissionsAdministration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation.
    /// </summary>
    public enum AppPermissionsAdministration
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsAdministrationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsAdministration value)
        {
            return value switch
            {
                AppPermissionsAdministration.Read => "read",
                AppPermissionsAdministration.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsAdministration? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsAdministration.Read,
                "write" => AppPermissionsAdministration.Write,
                _ => null,
            };
        }
    }
}