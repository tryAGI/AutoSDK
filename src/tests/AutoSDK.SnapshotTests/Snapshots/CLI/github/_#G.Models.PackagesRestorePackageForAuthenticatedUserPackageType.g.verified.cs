﻿//HintName: G.Models.PackagesRestorePackageForAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesRestorePackageForAuthenticatedUserPackageType
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
    public static class PackagesRestorePackageForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesRestorePackageForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesRestorePackageForAuthenticatedUserPackageType.Npm => "npm",
                PackagesRestorePackageForAuthenticatedUserPackageType.Maven => "maven",
                PackagesRestorePackageForAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesRestorePackageForAuthenticatedUserPackageType.Docker => "docker",
                PackagesRestorePackageForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesRestorePackageForAuthenticatedUserPackageType.Container => "container",
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
                "npm" => PackagesRestorePackageForAuthenticatedUserPackageType.Npm,
                "maven" => PackagesRestorePackageForAuthenticatedUserPackageType.Maven,
                "rubygems" => PackagesRestorePackageForAuthenticatedUserPackageType.Rubygems,
                "docker" => PackagesRestorePackageForAuthenticatedUserPackageType.Docker,
                "nuget" => PackagesRestorePackageForAuthenticatedUserPackageType.Nuget,
                "container" => PackagesRestorePackageForAuthenticatedUserPackageType.Container,
                _ => null,
            };
        }
    }
}