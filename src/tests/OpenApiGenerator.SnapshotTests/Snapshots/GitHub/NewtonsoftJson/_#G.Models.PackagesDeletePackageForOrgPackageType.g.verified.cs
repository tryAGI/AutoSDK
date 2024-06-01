//HintName: G.Models.PackagesDeletePackageForOrgPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesDeletePackageForOrgPackageType
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
    public static class PackagesDeletePackageForOrgPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageForOrgPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageForOrgPackageType.Npm => "npm",
                PackagesDeletePackageForOrgPackageType.Maven => "maven",
                PackagesDeletePackageForOrgPackageType.Rubygems => "rubygems",
                PackagesDeletePackageForOrgPackageType.Docker => "docker",
                PackagesDeletePackageForOrgPackageType.Nuget => "nuget",
                PackagesDeletePackageForOrgPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageForOrgPackageType ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesDeletePackageForOrgPackageType.Npm,
                "maven" => PackagesDeletePackageForOrgPackageType.Maven,
                "rubygems" => PackagesDeletePackageForOrgPackageType.Rubygems,
                "docker" => PackagesDeletePackageForOrgPackageType.Docker,
                "nuget" => PackagesDeletePackageForOrgPackageType.Nuget,
                "container" => PackagesDeletePackageForOrgPackageType.Container,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}