//HintName: G.Models.PackagesRestorePackageVersionForAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesRestorePackageVersionForAuthenticatedUserPackageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="container")]
        Container,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="docker")]
        Docker,
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
        [global::System.Runtime.Serialization.EnumMember(Value="rubygems")]
        Rubygems,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackagesRestorePackageVersionForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesRestorePackageVersionForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesRestorePackageVersionForAuthenticatedUserPackageType.Container => "container",
                PackagesRestorePackageVersionForAuthenticatedUserPackageType.Docker => "docker",
                PackagesRestorePackageVersionForAuthenticatedUserPackageType.Maven => "maven",
                PackagesRestorePackageVersionForAuthenticatedUserPackageType.Npm => "npm",
                PackagesRestorePackageVersionForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesRestorePackageVersionForAuthenticatedUserPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesRestorePackageVersionForAuthenticatedUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesRestorePackageVersionForAuthenticatedUserPackageType.Container,
                "docker" => PackagesRestorePackageVersionForAuthenticatedUserPackageType.Docker,
                "maven" => PackagesRestorePackageVersionForAuthenticatedUserPackageType.Maven,
                "npm" => PackagesRestorePackageVersionForAuthenticatedUserPackageType.Npm,
                "nuget" => PackagesRestorePackageVersionForAuthenticatedUserPackageType.Nuget,
                "rubygems" => PackagesRestorePackageVersionForAuthenticatedUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}