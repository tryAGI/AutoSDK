//HintName: G.Models.RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The package's language or package management ecosystem.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rubygems")]
        Rubygems,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="npm")]
        Npm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pip")]
        Pip,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maven")]
        Maven,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nuget")]
        Nuget,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="composer")]
        Composer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="go")]
        Go,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rust")]
        Rust,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="erlang")]
        Erlang,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="actions")]
        Actions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pub")]
        Pub,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="swift")]
        Swift,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem value)
        {
            return value switch
            {
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Rubygems => "rubygems",
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Npm => "npm",
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Pip => "pip",
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Maven => "maven",
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Nuget => "nuget",
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Composer => "composer",
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Go => "go",
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Rust => "rust",
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Erlang => "erlang",
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Actions => "actions",
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Pub => "pub",
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Other => "other",
                RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Swift => "swift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem ToEnum(string value)
        {
            return value switch
            {
                "rubygems" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Rubygems,
                "npm" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Npm,
                "pip" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Pip,
                "maven" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Maven,
                "nuget" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Nuget,
                "composer" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Composer,
                "go" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Go,
                "rust" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Rust,
                "erlang" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Erlang,
                "actions" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Actions,
                "pub" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Pub,
                "other" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Other,
                "swift" => RepositoryAdvisoryCreateVulnerabilitiesPackageEcosystem.Swift,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}