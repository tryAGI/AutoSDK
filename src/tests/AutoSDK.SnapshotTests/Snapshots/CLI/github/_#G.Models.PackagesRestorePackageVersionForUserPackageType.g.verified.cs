﻿//HintName: G.Models.PackagesRestorePackageVersionForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesRestorePackageVersionForUserPackageType
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
    public static class PackagesRestorePackageVersionForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesRestorePackageVersionForUserPackageType value)
        {
            return value switch
            {
                PackagesRestorePackageVersionForUserPackageType.Npm => "npm",
                PackagesRestorePackageVersionForUserPackageType.Maven => "maven",
                PackagesRestorePackageVersionForUserPackageType.Rubygems => "rubygems",
                PackagesRestorePackageVersionForUserPackageType.Docker => "docker",
                PackagesRestorePackageVersionForUserPackageType.Nuget => "nuget",
                PackagesRestorePackageVersionForUserPackageType.Container => "container",
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
                "npm" => PackagesRestorePackageVersionForUserPackageType.Npm,
                "maven" => PackagesRestorePackageVersionForUserPackageType.Maven,
                "rubygems" => PackagesRestorePackageVersionForUserPackageType.Rubygems,
                "docker" => PackagesRestorePackageVersionForUserPackageType.Docker,
                "nuget" => PackagesRestorePackageVersionForUserPackageType.Nuget,
                "container" => PackagesRestorePackageVersionForUserPackageType.Container,
                _ => null,
            };
        }
    }
}