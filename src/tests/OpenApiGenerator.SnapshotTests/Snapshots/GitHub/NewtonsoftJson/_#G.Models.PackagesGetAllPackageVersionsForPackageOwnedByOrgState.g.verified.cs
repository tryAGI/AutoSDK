//HintName: G.Models.PackagesGetAllPackageVersionsForPackageOwnedByOrgState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: active
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesGetAllPackageVersionsForPackageOwnedByOrgState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deleted")]
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
        public static PackagesGetAllPackageVersionsForPackageOwnedByOrgState ToEnum(string value)
        {
            return value switch
            {
                "active" => PackagesGetAllPackageVersionsForPackageOwnedByOrgState.Active,
                "deleted" => PackagesGetAllPackageVersionsForPackageOwnedByOrgState.Deleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}