//HintName: G.Models.OrganizationProgrammaticAccessGrantRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of repository selection requested.
    /// </summary>
    public enum OrganizationProgrammaticAccessGrantRepositorySelection
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Subset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationProgrammaticAccessGrantRepositorySelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProgrammaticAccessGrantRepositorySelection value)
        {
            return value switch
            {
                OrganizationProgrammaticAccessGrantRepositorySelection.None => "none",
                OrganizationProgrammaticAccessGrantRepositorySelection.All => "all",
                OrganizationProgrammaticAccessGrantRepositorySelection.Subset => "subset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProgrammaticAccessGrantRepositorySelection ToEnum(string value)
        {
            return value switch
            {
                "none" => OrganizationProgrammaticAccessGrantRepositorySelection.None,
                "all" => OrganizationProgrammaticAccessGrantRepositorySelection.All,
                "subset" => OrganizationProgrammaticAccessGrantRepositorySelection.Subset,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}