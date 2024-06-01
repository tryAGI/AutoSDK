//HintName: G.Models.PackagesListPackagesForAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesListPackagesForAuthenticatedUserPackageType
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
    public static class PackagesListPackagesForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesListPackagesForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesListPackagesForAuthenticatedUserPackageType.Npm => "npm",
                PackagesListPackagesForAuthenticatedUserPackageType.Maven => "maven",
                PackagesListPackagesForAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesListPackagesForAuthenticatedUserPackageType.Docker => "docker",
                PackagesListPackagesForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesListPackagesForAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesListPackagesForAuthenticatedUserPackageType ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesListPackagesForAuthenticatedUserPackageType.Npm,
                "maven" => PackagesListPackagesForAuthenticatedUserPackageType.Maven,
                "rubygems" => PackagesListPackagesForAuthenticatedUserPackageType.Rubygems,
                "docker" => PackagesListPackagesForAuthenticatedUserPackageType.Docker,
                "nuget" => PackagesListPackagesForAuthenticatedUserPackageType.Nuget,
                "container" => PackagesListPackagesForAuthenticatedUserPackageType.Container,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}