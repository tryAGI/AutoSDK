//HintName: G.Models.PartitionNames.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for dataset partition names.
    /// </summary>
    public enum PartitionNames
    {
        /// <summary>
        /// 
        /// </summary>
        DataSourceIdPartition,
        /// <summary>
        /// 
        /// </summary>
        EvalDatasetIdPartition,
        /// <summary>
        /// 
        /// </summary>
        ExtractionSchemaIdPartition,
        /// <summary>
        /// 
        /// </summary>
        FileIdPartition,
        /// <summary>
        /// 
        /// </summary>
        FileParsingIdPartition,
        /// <summary>
        /// 
        /// </summary>
        PipelineFileIdPartition,
        /// <summary>
        /// 
        /// </summary>
        PipelineIdPartition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartitionNamesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartitionNames value)
        {
            return value switch
            {
                PartitionNames.DataSourceIdPartition => "data_source_id_partition",
                PartitionNames.EvalDatasetIdPartition => "eval_dataset_id_partition",
                PartitionNames.ExtractionSchemaIdPartition => "extraction_schema_id_partition",
                PartitionNames.FileIdPartition => "file_id_partition",
                PartitionNames.FileParsingIdPartition => "file_parsing_id_partition",
                PartitionNames.PipelineFileIdPartition => "pipeline_file_id_partition",
                PartitionNames.PipelineIdPartition => "pipeline_id_partition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartitionNames? ToEnum(string value)
        {
            return value switch
            {
                "data_source_id_partition" => PartitionNames.DataSourceIdPartition,
                "eval_dataset_id_partition" => PartitionNames.EvalDatasetIdPartition,
                "extraction_schema_id_partition" => PartitionNames.ExtractionSchemaIdPartition,
                "file_id_partition" => PartitionNames.FileIdPartition,
                "file_parsing_id_partition" => PartitionNames.FileParsingIdPartition,
                "pipeline_file_id_partition" => PartitionNames.PipelineFileIdPartition,
                "pipeline_id_partition" => PartitionNames.PipelineIdPartition,
                _ => null,
            };
        }
    }
}