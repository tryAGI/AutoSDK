//HintName: G.Models.PackagesRestorePackageForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesRestorePackageForUserPackageType
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
    public static class PackagesRestorePackageForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesRestorePackageForUserPackageType value)
        {
            return value switch
            {
                PackagesRestorePackageForUserPackageType.Npm => "npm",
                PackagesRestorePackageForUserPackageType.Maven => "maven",
                PackagesRestorePackageForUserPackageType.Rubygems => "rubygems",
                PackagesRestorePackageForUserPackageType.Docker => "docker",
                PackagesRestorePackageForUserPackageType.Nuget => "nuget",
                PackagesRestorePackageForUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesRestorePackageForUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesRestorePackageForUserPackageType.Npm,
                "maven" => PackagesRestorePackageForUserPackageType.Maven,
                "rubygems" => PackagesRestorePackageForUserPackageType.Rubygems,
                "docker" => PackagesRestorePackageForUserPackageType.Docker,
                "nuget" => PackagesRestorePackageForUserPackageType.Nuget,
                "container" => PackagesRestorePackageForUserPackageType.Container,
                _ => null,
            };
        }
    }
}