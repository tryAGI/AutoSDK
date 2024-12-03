//HintName: G.Models.ProjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `active` or `archived`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="archived")]
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectStatus value)
        {
            return value switch
            {
                ProjectStatus.Active => "active",
                ProjectStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ProjectStatus.Active,
                "archived" => ProjectStatus.Archived,
                _ => null,
            };
        }
    }
}