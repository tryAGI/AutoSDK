//HintName: G.Models.CreateModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response object for creating a model. When finished, `status` is `success`.
    /// </summary>
    public sealed partial class CreateModelResponse
    {
        /// <summary>
        /// Status creating the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateModelStatusJsonConverter))]
        public global::G.CreateModelStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status creating the model
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateModelResponse(
            global::G.CreateModelStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelResponse" /> class.
        /// </summary>
        public CreateModelResponse()
        {
        }
    }
}