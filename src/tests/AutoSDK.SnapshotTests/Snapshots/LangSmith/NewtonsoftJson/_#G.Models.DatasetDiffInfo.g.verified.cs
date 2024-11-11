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
        [global::Newtonsoft.Json.JsonProperty("examples_modified", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> ExamplesModified { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("examples_added", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> ExamplesAdded { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("examples_removed", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> ExamplesRemoved { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetDiffInfo" /> class.
        /// </summary>
        /// <param name="examplesModified"></param>
        /// <param name="examplesAdded"></param>
        /// <param name="examplesRemoved"></param>
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