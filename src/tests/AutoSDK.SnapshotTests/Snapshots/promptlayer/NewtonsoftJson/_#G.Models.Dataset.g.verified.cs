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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Associated dataset group ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_group_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int DatasetGroupId { get; set; } = default!;

        /// <summary>
        /// Version number of the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionNumber { get; set; } = default!;

        /// <summary>
        /// Array of column names in the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_names", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ColumnNames { get; set; } = default!;

        /// <summary>
        /// Filter parameters used to create the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_params")]
        public object? FilterParams { get; set; }

        /// <summary>
        /// Whether the dataset is deleted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDeleted { get; set; } = default!;

        /// <summary>
        /// ID of the user who created the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int UserId { get; set; } = default!;

        /// <summary>
        /// Associated dataset group information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_group")]
        public global::G.DatasetGroup? DatasetGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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