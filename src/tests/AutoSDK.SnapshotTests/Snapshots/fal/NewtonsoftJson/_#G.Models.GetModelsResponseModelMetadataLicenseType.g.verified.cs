//HintName: G.Models.GetModelsResponseModelMetadataLicenseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// License type for the model (optional)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetModelsResponseModelMetadataLicenseType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commercial")]
        Commercial,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="research")]
        Research,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsResponseModelMetadataLicenseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsResponseModelMetadataLicenseType value)
        {
            return value switch
            {
                GetModelsResponseModelMetadataLicenseType.Commercial => "commercial",
                GetModelsResponseModelMetadataLicenseType.Private => "private",
                GetModelsResponseModelMetadataLicenseType.Research => "research",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsResponseModelMetadataLicenseType? ToEnum(string value)
        {
            return value switch
            {
                "commercial" => GetModelsResponseModelMetadataLicenseType.Commercial,
                "private" => GetModelsResponseModelMetadataLicenseType.Private,
                "research" => GetModelsResponseModelMetadataLicenseType.Research,
                _ => null,
            };
        }
    }
}