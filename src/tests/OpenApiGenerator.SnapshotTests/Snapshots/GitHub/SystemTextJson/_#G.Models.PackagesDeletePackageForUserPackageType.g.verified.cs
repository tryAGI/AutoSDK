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
    public static class PackagesDeletePackageForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageForUserPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageForUserPackageType.Npm => "npm",
                PackagesDeletePackageForUserPackageType.Maven => "maven",
                PackagesDeletePackageForUserPackageType.Rubygems => "rubygems",
                PackagesDeletePackageForUserPackageType.Docker => "docker",
                PackagesDeletePackageForUserPackageType.Nuget => "nuget",
                PackagesDeletePackageForUserPackageType.Container => "container",
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
                "npm" => PackagesDeletePackageForUserPackageType.Npm,
                "maven" => PackagesDeletePackageForUserPackageType.Maven,
                "rubygems" => PackagesDeletePackageForUserPackageType.Rubygems,
                "docker" => PackagesDeletePackageForUserPackageType.Docker,
                "nuget" => PackagesDeletePackageForUserPackageType.Nuget,
                "container" => PackagesDeletePackageForUserPackageType.Container,
                _ => null,
            };
        }
    }
}