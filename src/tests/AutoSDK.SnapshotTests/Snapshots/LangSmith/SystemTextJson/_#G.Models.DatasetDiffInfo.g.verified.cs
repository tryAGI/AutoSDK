//HintName: G.Models.DatasetDiffInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset diff schema.
    /// </summary>
    public sealed partial class DatasetDiffInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples_modified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ExamplesModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples_added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ExamplesAdded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples_removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ExamplesRemoved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetDiffInfo" /> class.
        /// </summary>
        /// <param name="examplesModified"></param>
        /// <param name="examplesAdded"></param>
        /// <param name="examplesRemoved"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DatasetDiffInfo(
            global::System.Collections.Generic.IList<global::System.Guid> examplesModified,
            global::System.Collections.Generic.IList<global::System.Guid> examplesAdded,
            global::System.Collections.Generic.IList<global::System.Guid> examplesRemoved)
        {
            this.ExamplesModified = examplesModified ?? throw new global::System.ArgumentNullException(nameof(examplesModified));
            this.ExamplesAdded = examplesAdded ?? throw new global::System.ArgumentNullException(nameof(examplesAdded));
            this.ExamplesRemoved = examplesRemoved ?? throw new global::System.ArgumentNullException(nameof(examplesRemoved));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetDiffInfo" /> class.
        /// </summary>
        public DatasetDiffInfo()
        {
        }
    }
}