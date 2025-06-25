//HintName: G.Models.PackagesListPackagesForAuthenticatedUserVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesListPackagesForAuthenticatedUserVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackagesListPackagesForAuthenticatedUserVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesListPackagesForAuthenticatedUserVisibility value)
        {
            return value switch
            {
                PackagesListPackagesForAuthenticatedUserVisibility.Public => "public",
                PackagesListPackagesForAuthenticatedUserVisibility.Private => "private",
                PackagesListPackagesForAuthenticatedUserVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesListPackagesForAuthenticatedUserVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => PackagesListPackagesForAuthenticatedUserVisibility.Public,
                "private" => PackagesListPackagesForAuthenticatedUserVisibility.Private,
                "internal" => PackagesListPackagesForAuthenticatedUserVisibility.Internal,
                _ => null,
            };
        }
    }
}