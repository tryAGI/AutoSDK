﻿//HintName: G.Models.ClassifyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifyRequest
    {
        /// <summary>
        /// An array of examples to provide context to the model. Each example is a text string and its associated label/class. Each unique label requires at least 2 examples associated with it; the maximum number of examples is 2500, and each example has a maximum length of 512 tokens. The values should be structured as `{text: "...",label: "..."}`.<br/>
        /// Note: [Fine-tuned Models](https://docs.cohere.com/docs/classify-fine-tuning) trained on classification examples don't require the `examples` parameter to be passed in explicitly.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<global::G.ClassifyExample>? Examples { get; set; }

        /// <summary>
        /// A list of up to 96 texts to be classified. Each one must be a non-empty string.<br/>
        /// There is, however, no consistent, universal limit to the length a particular input can be. We perform classification on the first `x` tokens of each input, and `x` varies depending on which underlying model is powering classification. The maximum token length for each model is listed in the "max tokens" column [here](https://docs.cohere.com/docs/models).<br/>
        /// Note: by default the `truncate` parameter is set to `END`, so tokens exceeding the limit will be automatically dropped. This behavior can be disabled by setting `truncate` to `NONE`, which will result in validation errors for longer texts.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.IList<string>? Inputs { get; set; }

        /// <summary>
        /// ID of a [Fine-tuned](https://docs.cohere.com/v2/docs/classify-starting-the-training) Classify model<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The ID of a custom playground preset. You can create presets in the [playground](https://dashboard.cohere.com/playground/classify?model=large). If you use a preset, all other parameters become optional, and any included parameters will override the preset's parameters.<br/>
        /// Included only in requests<br/>
        /// Example: my-preset-a58sbd
        /// </summary>
        /// <example>my-preset-a58sbd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Preset { get; set; }

        /// <summary>
        /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
        /// Default Value: END<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassifyRequestTruncateJsonConverter))]
        public global::G.ClassifyRequestTruncate? Truncate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyRequest" /> class.
        /// </summary>
        /// <param name="examples">
        /// An array of examples to provide context to the model. Each example is a text string and its associated label/class. Each unique label requires at least 2 examples associated with it; the maximum number of examples is 2500, and each example has a maximum length of 512 tokens. The values should be structured as `{text: "...",label: "..."}`.<br/>
        /// Note: [Fine-tuned Models](https://docs.cohere.com/docs/classify-fine-tuning) trained on classification examples don't require the `examples` parameter to be passed in explicitly.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="inputs">
        /// A list of up to 96 texts to be classified. Each one must be a non-empty string.<br/>
        /// There is, however, no consistent, universal limit to the length a particular input can be. We perform classification on the first `x` tokens of each input, and `x` varies depending on which underlying model is powering classification. The maximum token length for each model is listed in the "max tokens" column [here](https://docs.cohere.com/docs/models).<br/>
        /// Note: by default the `truncate` parameter is set to `END`, so tokens exceeding the limit will be automatically dropped. This behavior can be disabled by setting `truncate` to `NONE`, which will result in validation errors for longer texts.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="model">
        /// ID of a [Fine-tuned](https://docs.cohere.com/v2/docs/classify-starting-the-training) Classify model<br/>
        /// Included only in requests
        /// </param>
        /// <param name="truncate">
        /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
        /// Default Value: END<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyRequest(
            global::System.Collections.Generic.IList<global::G.ClassifyExample>? examples,
            global::System.Collections.Generic.IList<string>? inputs,
            string? model,
            global::G.ClassifyRequestTruncate? truncate)
        {
            this.Examples = examples;
            this.Inputs = inputs;
            this.Model = model;
            this.Truncate = truncate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyRequest" /> class.
        /// </summary>
        public ClassifyRequest()
        {
        }
    }
}