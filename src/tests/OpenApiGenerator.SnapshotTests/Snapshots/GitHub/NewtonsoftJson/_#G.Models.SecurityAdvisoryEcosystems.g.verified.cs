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
    public static class SecurityAdvisoryEcosystemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoryEcosystems value)
        {
            return value switch
            {
                SecurityAdvisoryEcosystems.Rubygems => "rubygems",
                SecurityAdvisoryEcosystems.Npm => "npm",
                SecurityAdvisoryEcosystems.Pip => "pip",
                SecurityAdvisoryEcosystems.Maven => "maven",
                SecurityAdvisoryEcosystems.Nuget => "nuget",
                SecurityAdvisoryEcosystems.Composer => "composer",
                SecurityAdvisoryEcosystems.Go => "go",
                SecurityAdvisoryEcosystems.Rust => "rust",
                SecurityAdvisoryEcosystems.Erlang => "erlang",
                SecurityAdvisoryEcosystems.Actions => "actions",
                SecurityAdvisoryEcosystems.Pub => "pub",
                SecurityAdvisoryEcosystems.Other => "other",
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
                "rubygems" => SecurityAdvisoryEcosystems.Rubygems,
                "npm" => SecurityAdvisoryEcosystems.Npm,
                "pip" => SecurityAdvisoryEcosystems.Pip,
                "maven" => SecurityAdvisoryEcosystems.Maven,
                "nuget" => SecurityAdvisoryEcosystems.Nuget,
                "composer" => SecurityAdvisoryEcosystems.Composer,
                "go" => SecurityAdvisoryEcosystems.Go,
                "rust" => SecurityAdvisoryEcosystems.Rust,
                "erlang" => SecurityAdvisoryEcosystems.Erlang,
                "actions" => SecurityAdvisoryEcosystems.Actions,
                "pub" => SecurityAdvisoryEcosystems.Pub,
                "other" => SecurityAdvisoryEcosystems.Other,
                "swift" => SecurityAdvisoryEcosystems.Swift,
                _ => null,
            };
        }
    }
}