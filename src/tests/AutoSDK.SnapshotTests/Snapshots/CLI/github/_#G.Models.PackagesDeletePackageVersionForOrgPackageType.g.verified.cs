﻿//HintName: G.Models.PackagesDeletePackageVersionForOrgPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesDeletePackageVersionForOrgPackageType
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
    public static class PackagesDeletePackageVersionForOrgPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageVersionForOrgPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageVersionForOrgPackageType.Npm => "npm",
                PackagesDeletePackageVersionForOrgPackageType.Maven => "maven",
                PackagesDeletePackageVersionForOrgPackageType.Rubygems => "rubygems",
                PackagesDeletePackageVersionForOrgPackageType.Docker => "docker",
                PackagesDeletePackageVersionForOrgPackageType.Nuget => "nuget",
                PackagesDeletePackageVersionForOrgPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageVersionForOrgPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesDeletePackageVersionForOrgPackageType.Npm,
                "maven" => PackagesDeletePackageVersionForOrgPackageType.Maven,
                "rubygems" => PackagesDeletePackageVersionForOrgPackageType.Rubygems,
                "docker" => PackagesDeletePackageVersionForOrgPackageType.Docker,
                "nuget" => PackagesDeletePackageVersionForOrgPackageType.Nuget,
                "container" => PackagesDeletePackageVersionForOrgPackageType.Container,
                _ => null,
            };
        }
    }
}