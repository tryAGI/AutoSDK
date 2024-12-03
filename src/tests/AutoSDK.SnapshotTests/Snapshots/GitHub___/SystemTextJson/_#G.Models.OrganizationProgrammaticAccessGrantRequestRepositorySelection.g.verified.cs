//HintName: G.Models.OrganizationProgrammaticAccessGrantRequestRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of repository selection requested.
    /// </summary>
    public enum OrganizationProgrammaticAccessGrantRequestRepositorySelection
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
    public static class OrganizationProgrammaticAccessGrantRequestRepositorySelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProgrammaticAccessGrantRequestRepositorySelection value)
        {
            return value switch
            {
                OrganizationProgrammaticAccessGrantRequestRepositorySelection.None => "none",
                OrganizationProgrammaticAccessGrantRequestRepositorySelection.All => "all",
                OrganizationProgrammaticAccessGrantRequestRepositorySelection.Subset => "subset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProgrammaticAccessGrantRequestRepositorySelection? ToEnum(string value)
        {
            return value switch
            {
                "none" => OrganizationProgrammaticAccessGrantRequestRepositorySelection.None,
                "all" => OrganizationProgrammaticAccessGrantRequestRepositorySelection.All,
                "subset" => OrganizationProgrammaticAccessGrantRequestRepositorySelection.Subset,
                _ => null,
            };
        }
    }
}