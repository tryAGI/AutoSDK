//HintName: G.Models.SecurityAdvisoriesListGlobalAdvisoriesEcosystem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The package's language or package management ecosystem.
    /// </summary>
    public enum SecurityAdvisoriesListGlobalAdvisoriesEcosystem
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
    public static class SecurityAdvisoriesListGlobalAdvisoriesEcosystemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoriesListGlobalAdvisoriesEcosystem value)
        {
            return value switch
            {
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Rubygems => "rubygems",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Npm => "npm",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Pip => "pip",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Maven => "maven",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Nuget => "nuget",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Composer => "composer",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Go => "go",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Rust => "rust",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Erlang => "erlang",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Actions => "actions",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Pub => "pub",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Other => "other",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Swift => "swift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoriesListGlobalAdvisoriesEcosystem ToEnum(string value)
        {
            return value switch
            {
                "rubygems" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Rubygems,
                "npm" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Npm,
                "pip" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Pip,
                "maven" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Maven,
                "nuget" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Nuget,
                "composer" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Composer,
                "go" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Go,
                "rust" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Rust,
                "erlang" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Erlang,
                "actions" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Actions,
                "pub" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Pub,
                "other" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Other,
                "swift" => SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Swift,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}