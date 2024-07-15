//HintName: G.Models.PackagesRestorePackageVersionForOrgPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesRestorePackageVersionForOrgPackageType
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
    public static class PackagesRestorePackageVersionForOrgPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesRestorePackageVersionForOrgPackageType value)
        {
            return value switch
            {
                PackagesRestorePackageVersionForOrgPackageType.Npm => "npm",
                PackagesRestorePackageVersionForOrgPackageType.Maven => "maven",
                PackagesRestorePackageVersionForOrgPackageType.Rubygems => "rubygems",
                PackagesRestorePackageVersionForOrgPackageType.Docker => "docker",
                PackagesRestorePackageVersionForOrgPackageType.Nuget => "nuget",
                PackagesRestorePackageVersionForOrgPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesRestorePackageVersionForOrgPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesRestorePackageVersionForOrgPackageType.Npm,
                "maven" => PackagesRestorePackageVersionForOrgPackageType.Maven,
                "rubygems" => PackagesRestorePackageVersionForOrgPackageType.Rubygems,
                "docker" => PackagesRestorePackageVersionForOrgPackageType.Docker,
                "nuget" => PackagesRestorePackageVersionForOrgPackageType.Nuget,
                "container" => PackagesRestorePackageVersionForOrgPackageType.Container,
                _ => null,
            };
        }
    }
}