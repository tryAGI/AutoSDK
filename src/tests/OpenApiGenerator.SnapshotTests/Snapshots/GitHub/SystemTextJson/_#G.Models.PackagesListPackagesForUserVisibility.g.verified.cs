//HintName: G.Models.PackagesListPackagesForUserVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesListPackagesForUserVisibility
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
    public static class PackagesListPackagesForUserVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesListPackagesForUserVisibility value)
        {
            return value switch
            {
                PackagesListPackagesForUserVisibility.Public => "public",
                PackagesListPackagesForUserVisibility.Private => "private",
                PackagesListPackagesForUserVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesListPackagesForUserVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => PackagesListPackagesForUserVisibility.Public,
                "private" => PackagesListPackagesForUserVisibility.Private,
                "internal" => PackagesListPackagesForUserVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}