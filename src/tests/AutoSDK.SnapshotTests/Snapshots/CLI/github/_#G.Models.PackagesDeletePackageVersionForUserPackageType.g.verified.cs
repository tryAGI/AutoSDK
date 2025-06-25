﻿//HintName: G.Models.PackagesDeletePackageVersionForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesDeletePackageVersionForUserPackageType
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
    public static class PackagesDeletePackageVersionForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageVersionForUserPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageVersionForUserPackageType.Npm => "npm",
                PackagesDeletePackageVersionForUserPackageType.Maven => "maven",
                PackagesDeletePackageVersionForUserPackageType.Rubygems => "rubygems",
                PackagesDeletePackageVersionForUserPackageType.Docker => "docker",
                PackagesDeletePackageVersionForUserPackageType.Nuget => "nuget",
                PackagesDeletePackageVersionForUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageVersionForUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesDeletePackageVersionForUserPackageType.Npm,
                "maven" => PackagesDeletePackageVersionForUserPackageType.Maven,
                "rubygems" => PackagesDeletePackageVersionForUserPackageType.Rubygems,
                "docker" => PackagesDeletePackageVersionForUserPackageType.Docker,
                "nuget" => PackagesDeletePackageVersionForUserPackageType.Nuget,
                "container" => PackagesDeletePackageVersionForUserPackageType.Container,
                _ => null,
            };
        }
    }
}