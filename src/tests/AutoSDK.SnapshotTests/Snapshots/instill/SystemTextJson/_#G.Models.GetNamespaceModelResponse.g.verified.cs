//HintName: G.Models.GetNamespaceModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetNamespaceModelResponse contains the requested model.
    /// </summary>
    public sealed partial class GetNamespaceModelResponse
    {
        /// <summary>
        /// The model resource.<br/>
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
        /// Initializes a new instance of the <see cref="GetNamespaceModelResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// The model resource.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetNamespaceModelResponse(
            global::G.Model? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespaceModelResponse" /> class.
        /// </summary>
        public GetNamespaceModelResponse()
        {
        }
    }
}