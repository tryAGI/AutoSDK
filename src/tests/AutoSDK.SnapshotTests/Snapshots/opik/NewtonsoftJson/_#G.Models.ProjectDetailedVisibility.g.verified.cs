//HintName: G.Models.ProjectDetailedVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectDetailedVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectDetailedVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectDetailedVisibility value)
        {
            return value switch
            {
                ProjectDetailedVisibility.Private => "private",
                ProjectDetailedVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectDetailedVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => ProjectDetailedVisibility.Private,
                "public" => ProjectDetailedVisibility.Public,
                _ => null,
            };
        }
    }
}