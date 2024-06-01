//HintName: G.Models.ProjectsListCollaboratorsAffiliation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectsListCollaboratorsAffiliation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="outside")]
        Outside,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="direct")]
        Direct,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsListCollaboratorsAffiliationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsListCollaboratorsAffiliation value)
        {
            return value switch
            {
                ProjectsListCollaboratorsAffiliation.Outside => "outside",
                ProjectsListCollaboratorsAffiliation.Direct => "direct",
                ProjectsListCollaboratorsAffiliation.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsListCollaboratorsAffiliation ToEnum(string value)
        {
            return value switch
            {
                "outside" => ProjectsListCollaboratorsAffiliation.Outside,
                "direct" => ProjectsListCollaboratorsAffiliation.Direct,
                "all" => ProjectsListCollaboratorsAffiliation.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}