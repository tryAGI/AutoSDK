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
    public static class PackagesRestorePackageForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesRestorePackageForUserPackageType value)
        {
            return value switch
            {
                PackagesRestorePackageForUserPackageType.Container => "container",
                PackagesRestorePackageForUserPackageType.Docker => "docker",
                PackagesRestorePackageForUserPackageType.Maven => "maven",
                PackagesRestorePackageForUserPackageType.Npm => "npm",
                PackagesRestorePackageForUserPackageType.Nuget => "nuget",
                PackagesRestorePackageForUserPackageType.Rubygems => "rubygems",
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
                "container" => PackagesRestorePackageForUserPackageType.Container,
                "docker" => PackagesRestorePackageForUserPackageType.Docker,
                "maven" => PackagesRestorePackageForUserPackageType.Maven,
                "npm" => PackagesRestorePackageForUserPackageType.Npm,
                "nuget" => PackagesRestorePackageForUserPackageType.Nuget,
                "rubygems" => PackagesRestorePackageForUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}