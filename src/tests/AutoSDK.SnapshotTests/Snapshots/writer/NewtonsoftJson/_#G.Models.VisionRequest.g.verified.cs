//HintName: G.Models.VisionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VisionRequest
    {
        /// <summary>
        /// The model to use for image analysis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.VisionRequestModel Model { get; set; }

        /// <summary>
        /// The prompt to use for the image analysis. The prompt must include the name of each image variable, surrounded by double curly braces (`{{}}`). For example, `Describe the difference between the image {{image_1}} and the image {{image_2}}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VisionRequestFileVariable> Variables { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to use for the image analysis. The prompt must include the name of each image variable, surrounded by double curly braces (`{{}}`). For example, `Describe the difference between the image {{image_1}} and the image {{image_2}}`.
        /// </param>
        /// <param name="variables"></param>
        /// <param name="model">
        /// The model to use for image analysis.
        /// </param>
        public VisionRequest(
            string prompt,
            global::System.Collections.Generic.IList<global::G.VisionRequestFileVariable> variables,
            global::G.VisionRequestModel model)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionRequest" /> class.
        /// </summary>
        public VisionRequest()
        {
        }
    }
}