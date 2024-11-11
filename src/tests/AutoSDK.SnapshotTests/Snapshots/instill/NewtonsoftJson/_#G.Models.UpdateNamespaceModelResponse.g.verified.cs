//HintName: G.Models.UpdateNamespaceModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateNamespaceModelResponse contains the updated model.
    /// </summary>
    public sealed partial class UpdateNamespaceModelResponse
    {
        /// <summary>
        /// The updated model resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.Model? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNamespaceModelResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// The updated model resource.<br/>
        /// Included only in responses
        /// </param>
        public UpdateNamespaceModelResponse(
            global::G.Model? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNamespaceModelResponse" /> class.
        /// </summary>
        public UpdateNamespaceModelResponse()
        {
        }
    }
}