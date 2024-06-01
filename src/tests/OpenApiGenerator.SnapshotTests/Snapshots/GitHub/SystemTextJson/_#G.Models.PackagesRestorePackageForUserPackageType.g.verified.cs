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
        Npm,
        /// <summary>
        /// 
        /// </summary>
        Maven,
        /// <summary>
        /// 
        /// </summary>
        Rubygems,
        /// <summary>
        /// 
        /// </summary>
        Docker,
        /// <summary>
        /// 
        /// </summary>
        Nuget,
        /// <summary>
        /// 
        /// </summary>
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
        public static PackagesRestorePackageForUserPackageType ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesRestorePackageForUserPackageType.Npm,
                "maven" => PackagesRestorePackageForUserPackageType.Maven,
                "rubygems" => PackagesRestorePackageForUserPackageType.Rubygems,
                "docker" => PackagesRestorePackageForUserPackageType.Docker,
                "nuget" => PackagesRestorePackageForUserPackageType.Nuget,
                "container" => PackagesRestorePackageForUserPackageType.Container,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}