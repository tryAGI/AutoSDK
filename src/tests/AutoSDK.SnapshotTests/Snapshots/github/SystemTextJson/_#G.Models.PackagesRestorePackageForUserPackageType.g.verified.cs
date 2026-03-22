//HintName: G.Models.PackagesRestorePackageForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesRestorePackageForUserPackageType
    {
        /// <summary>
        /// 
        /// </summary>
        Container,
        /// <summary>
        /// 
        /// </summary>
        Docker,
        /// <summary>
        /// 
        /// </summary>
        Maven,
        /// <summary>
        /// 
        /// </summary>
        Npm,
        /// <summary>
        /// 
        /// </summary>
        Nuget,
        /// <summary>
        /// 
        /// </summary>
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