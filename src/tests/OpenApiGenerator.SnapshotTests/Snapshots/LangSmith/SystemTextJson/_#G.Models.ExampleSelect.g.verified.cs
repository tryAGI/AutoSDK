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
        Id,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
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
        DatasetId,
        /// <summary>
        /// 
        /// </summary>
        SourceRunId,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Inputs,
        /// <summary>
        /// 
        /// </summary>
        Outputs,
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
                ExampleSelect.Id => "id",
                ExampleSelect.CreatedAt => "created_at",
                ExampleSelect.ModifiedAt => "modified_at",
                ExampleSelect.Name => "name",
                ExampleSelect.DatasetId => "dataset_id",
                ExampleSelect.SourceRunId => "source_run_id",
                ExampleSelect.Metadata => "metadata",
                ExampleSelect.Inputs => "inputs",
                ExampleSelect.Outputs => "outputs",
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
                "id" => ExampleSelect.Id,
                "created_at" => ExampleSelect.CreatedAt,
                "modified_at" => ExampleSelect.ModifiedAt,
                "name" => ExampleSelect.Name,
                "dataset_id" => ExampleSelect.DatasetId,
                "source_run_id" => ExampleSelect.SourceRunId,
                "metadata" => ExampleSelect.Metadata,
                "inputs" => ExampleSelect.Inputs,
                "outputs" => ExampleSelect.Outputs,
                _ => null,
            };
        }
    }
}