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
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal")]
        Internal,
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
                PackagesListPackagesForOrganizationVisibility.Public => "public",
                PackagesListPackagesForOrganizationVisibility.Private => "private",
                PackagesListPackagesForOrganizationVisibility.Internal => "internal",
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
                "public" => PackagesListPackagesForOrganizationVisibility.Public,
                "private" => PackagesListPackagesForOrganizationVisibility.Private,
                "internal" => PackagesListPackagesForOrganizationVisibility.Internal,
                _ => null,
            };
        }
    }
}