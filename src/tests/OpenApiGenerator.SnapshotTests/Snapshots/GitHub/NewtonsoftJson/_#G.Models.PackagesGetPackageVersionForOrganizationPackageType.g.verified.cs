//HintName: G.Models.PackagesGetPackageVersionForOrganizationPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesGetPackageVersionForOrganizationPackageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="npm")]
        Npm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maven")]
        Maven,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rubygems")]
        Rubygems,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="docker")]
        Docker,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nuget")]
        Nuget,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="container")]
        Container,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackagesGetPackageVersionForOrganizationPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageVersionForOrganizationPackageType value)
        {
            return value switch
            {
                PackagesGetPackageVersionForOrganizationPackageType.Npm => "npm",
                PackagesGetPackageVersionForOrganizationPackageType.Maven => "maven",
                PackagesGetPackageVersionForOrganizationPackageType.Rubygems => "rubygems",
                PackagesGetPackageVersionForOrganizationPackageType.Docker => "docker",
                PackagesGetPackageVersionForOrganizationPackageType.Nuget => "nuget",
                PackagesGetPackageVersionForOrganizationPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetPackageVersionForOrganizationPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesGetPackageVersionForOrganizationPackageType.Npm,
                "maven" => PackagesGetPackageVersionForOrganizationPackageType.Maven,
                "rubygems" => PackagesGetPackageVersionForOrganizationPackageType.Rubygems,
                "docker" => PackagesGetPackageVersionForOrganizationPackageType.Docker,
                "nuget" => PackagesGetPackageVersionForOrganizationPackageType.Nuget,
                "container" => PackagesGetPackageVersionForOrganizationPackageType.Container,
                _ => null,
            };
        }
    }
}