//HintName: G.Models.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind
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
    public static class HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind value)
        {
            return value switch
            {
                HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Inbody => "inbody",
                HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Put => "put",
                HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind.S3 => "s3",
                HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "inbody" => HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Inbody,
                "put" => HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Put,
                "s3" => HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind.S3,
                "zip" => HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Zip,
                _ => null,
            };
        }
    }
}