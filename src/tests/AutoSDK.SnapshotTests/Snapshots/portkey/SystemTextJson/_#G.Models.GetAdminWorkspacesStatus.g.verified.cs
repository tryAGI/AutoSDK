//HintName: G.Models.GetAdminWorkspacesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAdminWorkspacesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAdminWorkspacesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAdminWorkspacesStatus value)
        {
            return value switch
            {
                GetAdminWorkspacesStatus.Active => "active",
                GetAdminWorkspacesStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAdminWorkspacesStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetAdminWorkspacesStatus.Active,
                "archived" => GetAdminWorkspacesStatus.Archived,
                _ => null,
            };
        }
    }
}