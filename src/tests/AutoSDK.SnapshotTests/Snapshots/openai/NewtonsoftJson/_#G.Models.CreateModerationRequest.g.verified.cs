//HintName: G.Models.CreateModerationRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModerationRequest
    {
        /// <summary>
        /// Input (or inputs) to classify. Can be a single string, an array of strings, or<br/>
        /// an array of multi-modal input objects similar to other models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateModerationRequestInputVariant3ItemVariant1, global::G.CreateModerationRequestInputVariant3ItemVariant2>>> Input { get; set; } = default!;

        /// <summary>
        /// The content moderation model you would like to use. Learn more in<br/>
        /// [the moderation guide](/docs/guides/moderation), and learn about<br/>
        /// available models [here](/docs/models#moderation).<br/>
        /// Default Value: omni-moderation-latest<br/>
        /// Example: omni-moderation-2024-09-26
        /// </summary>
        /// <example>omni-moderation-2024-09-26</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.AnyOf<string, global::G.CreateModerationRequestModel?>? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Input (or inputs) to classify. Can be a single string, an array of strings, or<br/>
        /// an array of multi-modal input objects similar to other models.
        /// </param>
        /// <param name="model">
        /// The content moderation model you would like to use. Learn more in<br/>
        /// [the moderation guide](/docs/guides/moderation), and learn about<br/>
        /// available models [here](/docs/models#moderation).<br/>
        /// Default Value: omni-moderation-latest<br/>
        /// Example: omni-moderation-2024-09-26
        /// </param>
        public CreateModerationRequest(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateModerationRequestInputVariant3ItemVariant1, global::G.CreateModerationRequestInputVariant3ItemVariant2>>> input,
            global::G.AnyOf<string, global::G.CreateModerationRequestModel?>? model)
        {
            this.Input = input;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequest" /> class.
        /// </summary>
        public CreateModerationRequest()
        {
        }
    }
}