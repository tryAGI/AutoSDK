//HintName: G.Models.PackagesGetPackageForOrganizationPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesGetPackageForOrganizationPackageType
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
    public static class PackagesGetPackageForOrganizationPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageForOrganizationPackageType value)
        {
            return value switch
            {
                PackagesGetPackageForOrganizationPackageType.Container => "container",
                PackagesGetPackageForOrganizationPackageType.Docker => "docker",
                PackagesGetPackageForOrganizationPackageType.Maven => "maven",
                PackagesGetPackageForOrganizationPackageType.Npm => "npm",
                PackagesGetPackageForOrganizationPackageType.Nuget => "nuget",
                PackagesGetPackageForOrganizationPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetPackageForOrganizationPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesGetPackageForOrganizationPackageType.Container,
                "docker" => PackagesGetPackageForOrganizationPackageType.Docker,
                "maven" => PackagesGetPackageForOrganizationPackageType.Maven,
                "npm" => PackagesGetPackageForOrganizationPackageType.Npm,
                "nuget" => PackagesGetPackageForOrganizationPackageType.Nuget,
                "rubygems" => PackagesGetPackageForOrganizationPackageType.Rubygems,
                _ => null,
            };
        }
    }
}