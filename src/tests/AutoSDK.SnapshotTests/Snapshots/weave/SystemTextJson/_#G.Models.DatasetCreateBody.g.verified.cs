//HintName: G.Models.DatasetCreateBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetCreateBody
    {
        /// <summary>
        /// The name of this dataset.  Datasets with the same name will be versioned together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of this dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Dataset rows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetCreateBody" /> class.
        /// </summary>
        /// <param name="rows">
        /// Dataset rows
        /// </param>
        /// <param name="name">
        /// The name of this dataset.  Datasets with the same name will be versioned together.
        /// </param>
        /// <param name="description">
        /// A description of this dataset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetCreateBody(
            global::System.Collections.Generic.IList<object> rows,
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetCreateBody" /> class.
        /// </summary>
        public DatasetCreateBody()
        {
        }
    }
}