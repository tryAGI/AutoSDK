//HintName: G.Models.PackageVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: private
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackageVisibility
    {
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
    public static class PackageVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackageVisibility value)
        {
            return value switch
            {
                PackageVisibility.Private => "private",
                PackageVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackageVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => PackageVisibility.Private,
                "public" => PackageVisibility.Public,
                _ => null,
            };
        }
    }
}