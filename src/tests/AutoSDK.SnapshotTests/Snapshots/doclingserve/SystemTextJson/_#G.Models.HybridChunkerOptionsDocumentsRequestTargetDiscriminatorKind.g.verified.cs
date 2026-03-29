//HintName: G.Models.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        Inbody,
        /// <summary>
        /// 
        /// </summary>
        Put,
        /// <summary>
        /// 
        /// </summary>
        S3,
        /// <summary>
        /// 
        /// </summary>
        Zip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind value)
        {
            return value switch
            {
                HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Inbody => "inbody",
                HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Put => "put",
                HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.S3 => "s3",
                HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "inbody" => HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Inbody,
                "put" => HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Put,
                "s3" => HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.S3,
                "zip" => HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Zip,
                _ => null,
            };
        }
    }
}