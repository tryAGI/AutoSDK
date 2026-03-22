//HintName: G.Models.PackagesRestorePackageForAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesRestorePackageForAuthenticatedUserPackageType
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
    public static class PackagesRestorePackageForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesRestorePackageForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesRestorePackageForAuthenticatedUserPackageType.Container => "container",
                PackagesRestorePackageForAuthenticatedUserPackageType.Docker => "docker",
                PackagesRestorePackageForAuthenticatedUserPackageType.Maven => "maven",
                PackagesRestorePackageForAuthenticatedUserPackageType.Npm => "npm",
                PackagesRestorePackageForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesRestorePackageForAuthenticatedUserPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesRestorePackageForAuthenticatedUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesRestorePackageForAuthenticatedUserPackageType.Container,
                "docker" => PackagesRestorePackageForAuthenticatedUserPackageType.Docker,
                "maven" => PackagesRestorePackageForAuthenticatedUserPackageType.Maven,
                "npm" => PackagesRestorePackageForAuthenticatedUserPackageType.Npm,
                "nuget" => PackagesRestorePackageForAuthenticatedUserPackageType.Nuget,
                "rubygems" => PackagesRestorePackageForAuthenticatedUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}