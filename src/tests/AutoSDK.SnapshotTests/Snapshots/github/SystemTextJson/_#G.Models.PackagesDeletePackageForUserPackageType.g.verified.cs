//HintName: G.Models.PackagesDeletePackageForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesDeletePackageForUserPackageType
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
    public static class PackagesDeletePackageForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageForUserPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageForUserPackageType.Container => "container",
                PackagesDeletePackageForUserPackageType.Docker => "docker",
                PackagesDeletePackageForUserPackageType.Maven => "maven",
                PackagesDeletePackageForUserPackageType.Npm => "npm",
                PackagesDeletePackageForUserPackageType.Nuget => "nuget",
                PackagesDeletePackageForUserPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageForUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesDeletePackageForUserPackageType.Container,
                "docker" => PackagesDeletePackageForUserPackageType.Docker,
                "maven" => PackagesDeletePackageForUserPackageType.Maven,
                "npm" => PackagesDeletePackageForUserPackageType.Npm,
                "nuget" => PackagesDeletePackageForUserPackageType.Nuget,
                "rubygems" => PackagesDeletePackageForUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}