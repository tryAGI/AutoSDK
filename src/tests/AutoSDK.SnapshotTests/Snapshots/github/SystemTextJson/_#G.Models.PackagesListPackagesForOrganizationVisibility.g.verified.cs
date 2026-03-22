//HintName: G.Models.PackagesListPackagesForOrganizationVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesListPackagesForOrganizationVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
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