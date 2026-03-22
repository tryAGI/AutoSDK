//HintName: G.Models.OrganizationProgrammaticAccessGrantRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of repository selection requested.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrganizationProgrammaticAccessGrantRepositorySelection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subset")]
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
                OrganizationProgrammaticAccessGrantRepositorySelection.All => "all",
                OrganizationProgrammaticAccessGrantRepositorySelection.None => "none",
                OrganizationProgrammaticAccessGrantRepositorySelection.Subset => "subset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProgrammaticAccessGrantRepositorySelection? ToEnum(string value)
        {
            return value switch
            {
                "all" => OrganizationProgrammaticAccessGrantRepositorySelection.All,
                "none" => OrganizationProgrammaticAccessGrantRepositorySelection.None,
                "subset" => OrganizationProgrammaticAccessGrantRepositorySelection.Subset,
                _ => null,
            };
        }
    }
}