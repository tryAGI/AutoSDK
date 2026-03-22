//HintName: G.Models.ExampleSelect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExampleSelect
    {
        /// <summary>
        /// 
        /// </summary>
        AttachmentUrls,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        DatasetId,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Inputs,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        ModifiedAt,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Outputs,
        /// <summary>
        /// 
        /// </summary>
        SourceRunId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExampleSelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExampleSelect value)
        {
            return value switch
            {
                ExampleSelect.AttachmentUrls => "attachment_urls",
                ExampleSelect.CreatedAt => "created_at",
                ExampleSelect.DatasetId => "dataset_id",
                ExampleSelect.Id => "id",
                ExampleSelect.Inputs => "inputs",
                ExampleSelect.Metadata => "metadata",
                ExampleSelect.ModifiedAt => "modified_at",
                ExampleSelect.Name => "name",
                ExampleSelect.Outputs => "outputs",
                ExampleSelect.SourceRunId => "source_run_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExampleSelect? ToEnum(string value)
        {
            return value switch
            {
                "attachment_urls" => ExampleSelect.AttachmentUrls,
                "created_at" => ExampleSelect.CreatedAt,
                "dataset_id" => ExampleSelect.DatasetId,
                "id" => ExampleSelect.Id,
                "inputs" => ExampleSelect.Inputs,
                "metadata" => ExampleSelect.Metadata,
                "modified_at" => ExampleSelect.ModifiedAt,
                "name" => ExampleSelect.Name,
                "outputs" => ExampleSelect.Outputs,
                "source_run_id" => ExampleSelect.SourceRunId,
                _ => null,
            };
        }
    }
}