//HintName: G.Models.CreateModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdTrainingJob")]
        public global::G.CreateModelResponseSdTrainingJob? SdTrainingJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelResponse" /> class.
        /// </summary>
        /// <param name="sdTrainingJob"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateModelResponse(
            global::G.CreateModelResponseSdTrainingJob? sdTrainingJob)
        {
            this.SdTrainingJob = sdTrainingJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelResponse" /> class.
        /// </summary>
        public CreateModelResponse()
        {
        }
    }
}