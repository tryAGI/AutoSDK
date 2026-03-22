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
    public static class PackagesGetPackageVersionForOrganizationPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageVersionForOrganizationPackageType value)
        {
            return value switch
            {
                PackagesGetPackageVersionForOrganizationPackageType.Container => "container",
                PackagesGetPackageVersionForOrganizationPackageType.Docker => "docker",
                PackagesGetPackageVersionForOrganizationPackageType.Maven => "maven",
                PackagesGetPackageVersionForOrganizationPackageType.Npm => "npm",
                PackagesGetPackageVersionForOrganizationPackageType.Nuget => "nuget",
                PackagesGetPackageVersionForOrganizationPackageType.Rubygems => "rubygems",
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
                "container" => PackagesGetPackageVersionForOrganizationPackageType.Container,
                "docker" => PackagesGetPackageVersionForOrganizationPackageType.Docker,
                "maven" => PackagesGetPackageVersionForOrganizationPackageType.Maven,
                "npm" => PackagesGetPackageVersionForOrganizationPackageType.Npm,
                "nuget" => PackagesGetPackageVersionForOrganizationPackageType.Nuget,
                "rubygems" => PackagesGetPackageVersionForOrganizationPackageType.Rubygems,
                _ => null,
            };
        }
    }
}