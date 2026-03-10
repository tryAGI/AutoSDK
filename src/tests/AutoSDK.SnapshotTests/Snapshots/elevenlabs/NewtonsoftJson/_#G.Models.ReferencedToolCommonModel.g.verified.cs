//HintName: G.Models.ReferencedToolCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reference to a tool for unit test evaluation.
    /// </summary>
    public sealed partial class ReferencedToolCommonModel
    {
        /// <summary>
        /// The ID of the tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of the tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReferencedToolCommonModelType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencedToolCommonModel" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the tool
        /// </param>
        /// <param name="type">
        /// The type of the tool
        /// </param>
        public ReferencedToolCommonModel(
            string id,
            global::G.ReferencedToolCommonModelType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencedToolCommonModel" /> class.
        /// </summary>
        public ReferencedToolCommonModel()
        {
        }
    }
}