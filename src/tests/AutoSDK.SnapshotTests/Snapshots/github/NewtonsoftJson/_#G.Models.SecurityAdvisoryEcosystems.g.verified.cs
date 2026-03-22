//HintName: G.Models.SecurityAdvisoryEcosystems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The package's language or package management ecosystem.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecurityAdvisoryEcosystems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="actions")]
        Actions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="composer")]
        Composer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="erlang")]
        Erlang,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="go")]
        Go,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maven")]
        Maven,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="npm")]
        Npm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nuget")]
        Nuget,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pip")]
        Pip,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pub")]
        Pub,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rubygems")]
        Rubygems,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rust")]
        Rust,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="swift")]
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