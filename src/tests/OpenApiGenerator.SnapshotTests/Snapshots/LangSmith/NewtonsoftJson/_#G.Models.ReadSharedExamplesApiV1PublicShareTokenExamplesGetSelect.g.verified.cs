//HintName: G.Models.ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: [id, created_at, modified_at, name, dataset_id, metadata, inputs, outputs]
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect
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
    public static class ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect value)
        {
            return value switch
            {
                ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.Id => "id",
                ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.CreatedAt => "created_at",
                ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.ModifiedAt => "modified_at",
                ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.Name => "name",
                ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.DatasetId => "dataset_id",
                ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.SourceRunId => "source_run_id",
                ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.Metadata => "metadata",
                ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.Inputs => "inputs",
                ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.Outputs => "outputs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect? ToEnum(string value)
        {
            return value switch
            {
                "id" => ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.Id,
                "created_at" => ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.CreatedAt,
                "modified_at" => ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.ModifiedAt,
                "name" => ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.Name,
                "dataset_id" => ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.DatasetId,
                "source_run_id" => ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.SourceRunId,
                "metadata" => ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.Metadata,
                "inputs" => ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.Inputs,
                "outputs" => ReadSharedExamplesApiV1PublicShareTokenExamplesGetSelect.Outputs,
                _ => null,
            };
        }
    }
}