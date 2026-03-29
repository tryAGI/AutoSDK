//HintName: G.Models.AssetMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates how you uploaded the asset.<br/>
    /// **Values**:<br/>
    /// - `direct`: Uploaded from your local file system<br/>
    /// - `url`: Uploaded from a publicly accessible URL
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssetMethod
    {
        /// <summary>
        /// Uploaded from your local file system
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="direct")]
        Direct,
        /// <summary>
        /// Uploaded from a publicly accessible URL
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetMethod value)
        {
            return value switch
            {
                AssetMethod.Direct => "direct",
                AssetMethod.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetMethod? ToEnum(string value)
        {
            return value switch
            {
                "direct" => AssetMethod.Direct,
                "url" => AssetMethod.Url,
                _ => null,
            };
        }
    }
}