//HintName: G.Models.PackagesListPackagesForOrganizationVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesListPackagesForOrganizationVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal")]
        Internal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackagesListPackagesForOrganizationVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesListPackagesForOrganizationVisibility value)
        {
            return value switch
            {
                PackagesListPackagesForOrganizationVisibility.Internal => "internal",
                PackagesListPackagesForOrganizationVisibility.Private => "private",
                PackagesListPackagesForOrganizationVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesListPackagesForOrganizationVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => PackagesListPackagesForOrganizationVisibility.Internal,
                "private" => PackagesListPackagesForOrganizationVisibility.Private,
                "public" => PackagesListPackagesForOrganizationVisibility.Public,
                _ => null,
            };
        }
    }
}