//HintName: G.Models.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind
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