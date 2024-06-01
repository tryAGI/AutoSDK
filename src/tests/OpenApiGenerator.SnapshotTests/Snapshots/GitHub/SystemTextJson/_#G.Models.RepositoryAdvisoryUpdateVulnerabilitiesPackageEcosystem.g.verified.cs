//HintName: G.Models.RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The package's language or package management ecosystem.
    /// </summary>
    public enum RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem
    {
        /// <summary>
        /// 
        /// </summary>
        Rubygems,
        /// <summary>
        /// 
        /// </summary>
        Npm,
        /// <summary>
        /// 
        /// </summary>
        Pip,
        /// <summary>
        /// 
        /// </summary>
        Maven,
        /// <summary>
        /// 
        /// </summary>
        Nuget,
        /// <summary>
        /// 
        /// </summary>
        Composer,
        /// <summary>
        /// 
        /// </summary>
        Go,
        /// <summary>
        /// 
        /// </summary>
        Rust,
        /// <summary>
        /// 
        /// </summary>
        Erlang,
        /// <summary>
        /// 
        /// </summary>
        Actions,
        /// <summary>
        /// 
        /// </summary>
        Pub,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Swift,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem value)
        {
            return value switch
            {
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Rubygems => "rubygems",
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Npm => "npm",
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Pip => "pip",
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Maven => "maven",
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Nuget => "nuget",
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Composer => "composer",
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Go => "go",
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Rust => "rust",
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Erlang => "erlang",
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Actions => "actions",
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Pub => "pub",
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Other => "other",
                RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Swift => "swift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem ToEnum(string value)
        {
            return value switch
            {
                "rubygems" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Rubygems,
                "npm" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Npm,
                "pip" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Pip,
                "maven" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Maven,
                "nuget" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Nuget,
                "composer" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Composer,
                "go" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Go,
                "rust" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Rust,
                "erlang" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Erlang,
                "actions" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Actions,
                "pub" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Pub,
                "other" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Other,
                "swift" => RepositoryAdvisoryUpdateVulnerabilitiesPackageEcosystem.Swift,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}