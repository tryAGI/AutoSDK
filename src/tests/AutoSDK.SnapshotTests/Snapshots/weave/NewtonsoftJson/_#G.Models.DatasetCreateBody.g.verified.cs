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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of this dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Dataset rows
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rows", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Rows { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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