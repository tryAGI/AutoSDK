//HintName: G.Models.UpsertVideoTranslationsApiRequestAutoGenerate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Automatically generate the translated video after translation completes. Set to 'private' to generate without sharing publicly, or 'public' to generate and publish immediately.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpsertVideoTranslationsApiRequestAutoGenerate
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
    public static class UpsertVideoTranslationsApiRequestAutoGenerateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertVideoTranslationsApiRequestAutoGenerate value)
        {
            return value switch
            {
                UpsertVideoTranslationsApiRequestAutoGenerate.Private => "private",
                UpsertVideoTranslationsApiRequestAutoGenerate.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertVideoTranslationsApiRequestAutoGenerate? ToEnum(string value)
        {
            return value switch
            {
                "private" => UpsertVideoTranslationsApiRequestAutoGenerate.Private,
                "public" => UpsertVideoTranslationsApiRequestAutoGenerate.Public,
                _ => null,
            };
        }
    }
}