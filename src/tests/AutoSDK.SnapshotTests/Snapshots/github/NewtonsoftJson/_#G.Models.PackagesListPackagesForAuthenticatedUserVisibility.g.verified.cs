//HintName: G.Models.PackagesListPackagesForAuthenticatedUserVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesListPackagesForAuthenticatedUserVisibility
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
    public static class PackagesListPackagesForAuthenticatedUserVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesListPackagesForAuthenticatedUserVisibility value)
        {
            return value switch
            {
                PackagesListPackagesForAuthenticatedUserVisibility.Internal => "internal",
                PackagesListPackagesForAuthenticatedUserVisibility.Private => "private",
                PackagesListPackagesForAuthenticatedUserVisibility.Public => "public",
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
                "internal" => PackagesListPackagesForAuthenticatedUserVisibility.Internal,
                "private" => PackagesListPackagesForAuthenticatedUserVisibility.Private,
                "public" => PackagesListPackagesForAuthenticatedUserVisibility.Public,
                _ => null,
            };
        }
    }
}