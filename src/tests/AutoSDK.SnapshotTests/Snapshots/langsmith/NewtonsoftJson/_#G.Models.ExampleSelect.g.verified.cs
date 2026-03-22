//HintName: G.Models.ExampleSelect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExampleSelect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="attachment_urls")]
        AttachmentUrls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset_id")]
        DatasetId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="id")]
        Id,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inputs")]
        Inputs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="metadata")]
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="modified_at")]
        ModifiedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name")]
        Name,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="outputs")]
        Outputs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="source_run_id")]
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