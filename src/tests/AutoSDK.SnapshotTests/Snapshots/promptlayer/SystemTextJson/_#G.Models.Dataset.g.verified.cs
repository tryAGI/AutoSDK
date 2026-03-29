//HintName: G.Models.Dataset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// Dataset ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Associated dataset group ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DatasetGroupId { get; set; }

        /// <summary>
        /// Version number of the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionNumber { get; set; }

        /// <summary>
        /// Array of column names in the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ColumnNames { get; set; }

        /// <summary>
        /// Filter parameters used to create the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_params")]
        public object? FilterParams { get; set; }

        /// <summary>
        /// Whether the dataset is deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDeleted { get; set; }

        /// <summary>
        /// ID of the user who created the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

        /// <summary>
        /// Associated dataset group information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group")]
        public global::G.DatasetGroup? DatasetGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="id">
        /// Dataset ID
        /// </param>
        /// <param name="datasetGroupId">
        /// Associated dataset group ID
        /// </param>
        /// <param name="versionNumber">
        /// Version number of the dataset
        /// </param>
        /// <param name="columnNames">
        /// Array of column names in the dataset
        /// </param>
        /// <param name="isDeleted">
        /// Whether the dataset is deleted
        /// </param>
        /// <param name="userId">
        /// ID of the user who created the dataset
        /// </param>
        /// <param name="filterParams">
        /// Filter parameters used to create the dataset
        /// </param>
        /// <param name="datasetGroup">
        /// Associated dataset group information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Dataset(
            int id,
            int datasetGroupId,
            int versionNumber,
            global::System.Collections.Generic.IList<string> columnNames,
            bool isDeleted,
            int userId,
            object? filterParams,
            global::G.DatasetGroup? datasetGroup)
        {
            this.Id = id;
            this.DatasetGroupId = datasetGroupId;
            this.VersionNumber = versionNumber;
            this.ColumnNames = columnNames ?? throw new global::System.ArgumentNullException(nameof(columnNames));
            this.FilterParams = filterParams;
            this.IsDeleted = isDeleted;
            this.UserId = userId;
            this.DatasetGroup = datasetGroup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}