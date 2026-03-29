//HintName: G.Models.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind
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
    public static class HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind value)
        {
            return value switch
            {
                HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind.File => "file",
                HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind.Http => "http",
                HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "file" => HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind.File,
                "http" => HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind.Http,
                "s3" => HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind.S3,
                _ => null,
            };
        }
    }
}