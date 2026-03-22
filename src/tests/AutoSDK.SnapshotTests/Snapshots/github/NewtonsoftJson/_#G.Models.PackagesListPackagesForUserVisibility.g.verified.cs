//HintName: G.Models.PackagesListPackagesForUserVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesListPackagesForUserVisibility
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
    public static class PackagesListPackagesForUserVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesListPackagesForUserVisibility value)
        {
            return value switch
            {
                PackagesListPackagesForUserVisibility.Internal => "internal",
                PackagesListPackagesForUserVisibility.Private => "private",
                PackagesListPackagesForUserVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesListPackagesForUserVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => PackagesListPackagesForUserVisibility.Internal,
                "private" => PackagesListPackagesForUserVisibility.Private,
                "public" => PackagesListPackagesForUserVisibility.Public,
                _ => null,
            };
        }
    }
}