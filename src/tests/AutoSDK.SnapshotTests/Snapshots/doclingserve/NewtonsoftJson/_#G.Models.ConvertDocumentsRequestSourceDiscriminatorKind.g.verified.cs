//HintName: G.Models.ConvertDocumentsRequestSourceDiscriminatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConvertDocumentsRequestSourceDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="http")]
        Http,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="s3")]
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConvertDocumentsRequestSourceDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConvertDocumentsRequestSourceDiscriminatorKind value)
        {
            return value switch
            {
                ConvertDocumentsRequestSourceDiscriminatorKind.File => "file",
                ConvertDocumentsRequestSourceDiscriminatorKind.Http => "http",
                ConvertDocumentsRequestSourceDiscriminatorKind.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConvertDocumentsRequestSourceDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "file" => ConvertDocumentsRequestSourceDiscriminatorKind.File,
                "http" => ConvertDocumentsRequestSourceDiscriminatorKind.Http,
                "s3" => ConvertDocumentsRequestSourceDiscriminatorKind.S3,
                _ => null,
            };
        }
    }
}