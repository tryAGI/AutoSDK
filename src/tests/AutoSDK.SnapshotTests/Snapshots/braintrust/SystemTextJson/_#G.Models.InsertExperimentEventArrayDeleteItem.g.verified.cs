//HintName: G.Models.InsertExperimentEventArrayDeleteItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsertExperimentEventArrayDeleteItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Delete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertExperimentEventArrayDeleteItem" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="delete"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsertExperimentEventArrayDeleteItem(
            global::System.Collections.Generic.IList<string> path,
            global::System.Collections.Generic.IList<object> delete)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Delete = delete ?? throw new global::System.ArgumentNullException(nameof(delete));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertExperimentEventArrayDeleteItem" /> class.
        /// </summary>
        public InsertExperimentEventArrayDeleteItem()
        {
        }
    }
}