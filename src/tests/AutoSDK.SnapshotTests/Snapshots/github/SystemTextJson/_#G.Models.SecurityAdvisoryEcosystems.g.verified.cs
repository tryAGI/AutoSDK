//HintName: G.Models.SecurityAdvisoryEcosystems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The package's language or package management ecosystem.
    /// </summary>
    public enum SecurityAdvisoryEcosystems
    {
        /// <summary>
        /// 
        /// </summary>
        Actions,
        /// <summary>
        /// 
        /// </summary>
        Composer,
        /// <summary>
        /// 
        /// </summary>
        Erlang,
        /// <summary>
        /// 
        /// </summary>
        Go,
        /// <summary>
        /// 
        /// </summary>
        Maven,
        /// <summary>
        /// 
        /// </summary>
        Npm,
        /// <summary>
        /// 
        /// </summary>
        Nuget,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Pip,
        /// <summary>
        /// 
        /// </summary>
        Pub,
        /// <summary>
        /// 
        /// </summary>
        Rubygems,
        /// <summary>
        /// 
        /// </summary>
        Rust,
        /// <summary>
        /// 
        /// </summary>
        Swift,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityAdvisoryEcosystemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoryEcosystems value)
        {
            return value switch
            {
                SecurityAdvisoryEcosystems.Actions => "actions",
                SecurityAdvisoryEcosystems.Composer => "composer",
                SecurityAdvisoryEcosystems.Erlang => "erlang",
                SecurityAdvisoryEcosystems.Go => "go",
                SecurityAdvisoryEcosystems.Maven => "maven",
                SecurityAdvisoryEcosystems.Npm => "npm",
                SecurityAdvisoryEcosystems.Nuget => "nuget",
                SecurityAdvisoryEcosystems.Other => "other",
                SecurityAdvisoryEcosystems.Pip => "pip",
                SecurityAdvisoryEcosystems.Pub => "pub",
                SecurityAdvisoryEcosystems.Rubygems => "rubygems",
                SecurityAdvisoryEcosystems.Rust => "rust",
                SecurityAdvisoryEcosystems.Swift => "swift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoryEcosystems? ToEnum(string value)
        {
            return value switch
            {
                "actions" => SecurityAdvisoryEcosystems.Actions,
                "composer" => SecurityAdvisoryEcosystems.Composer,
                "erlang" => SecurityAdvisoryEcosystems.Erlang,
                "go" => SecurityAdvisoryEcosystems.Go,
                "maven" => SecurityAdvisoryEcosystems.Maven,
                "npm" => SecurityAdvisoryEcosystems.Npm,
                "nuget" => SecurityAdvisoryEcosystems.Nuget,
                "other" => SecurityAdvisoryEcosystems.Other,
                "pip" => SecurityAdvisoryEcosystems.Pip,
                "pub" => SecurityAdvisoryEcosystems.Pub,
                "rubygems" => SecurityAdvisoryEcosystems.Rubygems,
                "rust" => SecurityAdvisoryEcosystems.Rust,
                "swift" => SecurityAdvisoryEcosystems.Swift,
                _ => null,
            };
        }
    }
}