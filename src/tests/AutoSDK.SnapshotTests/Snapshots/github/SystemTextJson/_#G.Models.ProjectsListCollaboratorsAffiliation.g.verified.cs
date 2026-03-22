//HintName: G.Models.ProjectsListCollaboratorsAffiliation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ProjectsListCollaboratorsAffiliation
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Outside,
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
                ProjectsListCollaboratorsAffiliation.All => "all",
                ProjectsListCollaboratorsAffiliation.Direct => "direct",
                ProjectsListCollaboratorsAffiliation.Outside => "outside",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsListCollaboratorsAffiliation? ToEnum(string value)
        {
            return value switch
            {
                "all" => ProjectsListCollaboratorsAffiliation.All,
                "direct" => ProjectsListCollaboratorsAffiliation.Direct,
                "outside" => ProjectsListCollaboratorsAffiliation.Outside,
                _ => null,
            };
        }
    }
}