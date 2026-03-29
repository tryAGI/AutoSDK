//HintName: G.Models.ClassifyV2JobResponseDocumentInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether the input was a file or parse job (FILE or PARSE_JOB)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClassifyV2JobResponseDocumentInputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_id")]
        FileId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parse_job_id")]
        ParseJobId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifyV2JobResponseDocumentInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifyV2JobResponseDocumentInputType value)
        {
            return value switch
            {
                ClassifyV2JobResponseDocumentInputType.FileId => "file_id",
                ClassifyV2JobResponseDocumentInputType.ParseJobId => "parse_job_id",
                ClassifyV2JobResponseDocumentInputType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifyV2JobResponseDocumentInputType? ToEnum(string value)
        {
            return value switch
            {
                "file_id" => ClassifyV2JobResponseDocumentInputType.FileId,
                "parse_job_id" => ClassifyV2JobResponseDocumentInputType.ParseJobId,
                "url" => ClassifyV2JobResponseDocumentInputType.Url,
                _ => null,
            };
        }
    }
}