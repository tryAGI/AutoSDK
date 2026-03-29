//HintName: G.Models.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the upload method for the asset. Use `direct` to upload a local file or `url` for a publicly accessible URL.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssetsPostRequestBodyContentMultipartFormDataSchemaMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="direct")]
        Direct,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetsPostRequestBodyContentMultipartFormDataSchemaMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetsPostRequestBodyContentMultipartFormDataSchemaMethod value)
        {
            return value switch
            {
                AssetsPostRequestBodyContentMultipartFormDataSchemaMethod.Direct => "direct",
                AssetsPostRequestBodyContentMultipartFormDataSchemaMethod.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetsPostRequestBodyContentMultipartFormDataSchemaMethod? ToEnum(string value)
        {
            return value switch
            {
                "direct" => AssetsPostRequestBodyContentMultipartFormDataSchemaMethod.Direct,
                "url" => AssetsPostRequestBodyContentMultipartFormDataSchemaMethod.Url,
                _ => null,
            };
        }
    }
}