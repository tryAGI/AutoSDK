//HintName: G.Models.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind
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
    public static class HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind value)
        {
            return value switch
            {
                HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind.File => "file",
                HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind.Http => "http",
                HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "file" => HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind.File,
                "http" => HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind.Http,
                "s3" => HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind.S3,
                _ => null,
            };
        }
    }
}