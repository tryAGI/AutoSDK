//HintName: G.Models.ConvertDocumentsRequestTargetDiscriminatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConvertDocumentsRequestTargetDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inbody")]
        Inbody,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="put")]
        Put,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="s3")]
        S3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zip")]
        Zip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConvertDocumentsRequestTargetDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConvertDocumentsRequestTargetDiscriminatorKind value)
        {
            return value switch
            {
                ConvertDocumentsRequestTargetDiscriminatorKind.Inbody => "inbody",
                ConvertDocumentsRequestTargetDiscriminatorKind.Put => "put",
                ConvertDocumentsRequestTargetDiscriminatorKind.S3 => "s3",
                ConvertDocumentsRequestTargetDiscriminatorKind.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConvertDocumentsRequestTargetDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "inbody" => ConvertDocumentsRequestTargetDiscriminatorKind.Inbody,
                "put" => ConvertDocumentsRequestTargetDiscriminatorKind.Put,
                "s3" => ConvertDocumentsRequestTargetDiscriminatorKind.S3,
                "zip" => ConvertDocumentsRequestTargetDiscriminatorKind.Zip,
                _ => null,
            };
        }
    }
}