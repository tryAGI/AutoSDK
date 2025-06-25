﻿//HintName: G.Models.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: active
    /// </summary>
    public enum PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState
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
    public static class PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState value)
        {
            return value switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState.Active => "active",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState? ToEnum(string value)
        {
            return value switch
            {
                "active" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState.Active,
                "deleted" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState.Deleted,
                _ => null,
            };
        }
    }
}