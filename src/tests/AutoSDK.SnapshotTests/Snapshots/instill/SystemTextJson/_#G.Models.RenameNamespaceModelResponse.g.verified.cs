//HintName: G.Models.RenameNamespaceModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// RenameNamespaceModelResponse contains a renamed model.
    /// </summary>
    public sealed partial class RenameNamespaceModelResponse
    {
        /// <summary>
        /// The renamed model resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::G.Model? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameNamespaceModelResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// The renamed model resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenameNamespaceModelResponse(
            global::G.Model? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameNamespaceModelResponse" /> class.
        /// </summary>
        public RenameNamespaceModelResponse()
        {
        }
    }
}