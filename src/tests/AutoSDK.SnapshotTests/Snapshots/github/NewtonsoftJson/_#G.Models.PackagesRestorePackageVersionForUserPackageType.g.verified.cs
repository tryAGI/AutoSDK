//HintName: G.Models.PackagesRestorePackageVersionForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesRestorePackageVersionForUserPackageType
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
    public static class PackagesRestorePackageVersionForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesRestorePackageVersionForUserPackageType value)
        {
            return value switch
            {
                PackagesRestorePackageVersionForUserPackageType.Container => "container",
                PackagesRestorePackageVersionForUserPackageType.Docker => "docker",
                PackagesRestorePackageVersionForUserPackageType.Maven => "maven",
                PackagesRestorePackageVersionForUserPackageType.Npm => "npm",
                PackagesRestorePackageVersionForUserPackageType.Nuget => "nuget",
                PackagesRestorePackageVersionForUserPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesRestorePackageVersionForUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesRestorePackageVersionForUserPackageType.Container,
                "docker" => PackagesRestorePackageVersionForUserPackageType.Docker,
                "maven" => PackagesRestorePackageVersionForUserPackageType.Maven,
                "npm" => PackagesRestorePackageVersionForUserPackageType.Npm,
                "nuget" => PackagesRestorePackageVersionForUserPackageType.Nuget,
                "rubygems" => PackagesRestorePackageVersionForUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}