﻿//HintName: G.Models.PackagesGetAllPackageVersionsForPackageOwnedByOrgState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: active
    /// </summary>
    public enum PackagesGetAllPackageVersionsForPackageOwnedByOrgState
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackagesGetAllPackageVersionsForPackageOwnedByOrgStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetAllPackageVersionsForPackageOwnedByOrgState value)
        {
            return value switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByOrgState.Active => "active",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgState.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetAllPackageVersionsForPackageOwnedByOrgState? ToEnum(string value)
        {
            return value switch
            {
                "active" => PackagesGetAllPackageVersionsForPackageOwnedByOrgState.Active,
                "deleted" => PackagesGetAllPackageVersionsForPackageOwnedByOrgState.Deleted,
                _ => null,
            };
        }
    }
}