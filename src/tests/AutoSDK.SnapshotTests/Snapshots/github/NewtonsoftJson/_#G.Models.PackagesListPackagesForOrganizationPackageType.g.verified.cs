//HintName: G.Models.PackagesListPackagesForOrganizationPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesListPackagesForOrganizationPackageType
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
    public static class PackagesListPackagesForOrganizationPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesListPackagesForOrganizationPackageType value)
        {
            return value switch
            {
                PackagesListPackagesForOrganizationPackageType.Container => "container",
                PackagesListPackagesForOrganizationPackageType.Docker => "docker",
                PackagesListPackagesForOrganizationPackageType.Maven => "maven",
                PackagesListPackagesForOrganizationPackageType.Npm => "npm",
                PackagesListPackagesForOrganizationPackageType.Nuget => "nuget",
                PackagesListPackagesForOrganizationPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesListPackagesForOrganizationPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesListPackagesForOrganizationPackageType.Container,
                "docker" => PackagesListPackagesForOrganizationPackageType.Docker,
                "maven" => PackagesListPackagesForOrganizationPackageType.Maven,
                "npm" => PackagesListPackagesForOrganizationPackageType.Npm,
                "nuget" => PackagesListPackagesForOrganizationPackageType.Nuget,
                "rubygems" => PackagesListPackagesForOrganizationPackageType.Rubygems,
                _ => null,
            };
        }
    }
}