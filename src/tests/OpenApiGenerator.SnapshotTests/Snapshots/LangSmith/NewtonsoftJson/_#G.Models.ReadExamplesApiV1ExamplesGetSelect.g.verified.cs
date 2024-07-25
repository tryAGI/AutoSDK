//HintName: G.Models.ReadExamplesApiV1ExamplesGetSelect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: [id, created_at, modified_at, name, dataset_id, source_run_id, metadata, inputs, outputs]
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReadExamplesApiV1ExamplesGetSelect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="id")]
        Id,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
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
        [global::System.Runtime.Serialization.EnumMember(Value="dataset_id")]
        DatasetId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="source_run_id")]
        SourceRunId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="metadata")]
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inputs")]
        Inputs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="outputs")]
        Outputs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReadExamplesApiV1ExamplesGetSelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadExamplesApiV1ExamplesGetSelect value)
        {
            return value switch
            {
                ReadExamplesApiV1ExamplesGetSelect.Id => "id",
                ReadExamplesApiV1ExamplesGetSelect.CreatedAt => "created_at",
                ReadExamplesApiV1ExamplesGetSelect.ModifiedAt => "modified_at",
                ReadExamplesApiV1ExamplesGetSelect.Name => "name",
                ReadExamplesApiV1ExamplesGetSelect.DatasetId => "dataset_id",
                ReadExamplesApiV1ExamplesGetSelect.SourceRunId => "source_run_id",
                ReadExamplesApiV1ExamplesGetSelect.Metadata => "metadata",
                ReadExamplesApiV1ExamplesGetSelect.Inputs => "inputs",
                ReadExamplesApiV1ExamplesGetSelect.Outputs => "outputs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadExamplesApiV1ExamplesGetSelect? ToEnum(string value)
        {
            return value switch
            {
                "id" => ReadExamplesApiV1ExamplesGetSelect.Id,
                "created_at" => ReadExamplesApiV1ExamplesGetSelect.CreatedAt,
                "modified_at" => ReadExamplesApiV1ExamplesGetSelect.ModifiedAt,
                "name" => ReadExamplesApiV1ExamplesGetSelect.Name,
                "dataset_id" => ReadExamplesApiV1ExamplesGetSelect.DatasetId,
                "source_run_id" => ReadExamplesApiV1ExamplesGetSelect.SourceRunId,
                "metadata" => ReadExamplesApiV1ExamplesGetSelect.Metadata,
                "inputs" => ReadExamplesApiV1ExamplesGetSelect.Inputs,
                "outputs" => ReadExamplesApiV1ExamplesGetSelect.Outputs,
                _ => null,
            };
        }
    }
}