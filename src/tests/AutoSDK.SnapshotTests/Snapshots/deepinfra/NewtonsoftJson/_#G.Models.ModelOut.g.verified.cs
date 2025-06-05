//HintName: G.Models.ModelOut.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelOut
    {
        /// <summary>
        /// Model Name<br/>
        /// Example: microsoft/resnet-50
        /// </summary>
        /// <example>microsoft/resnet-50</example>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// raw type of the model<br/>
        /// Example: image-classification
        /// </summary>
        /// <example>image-classification</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// reported type of the model<br/>
        /// Example: text-generation
        /// </summary>
        /// <example>text-generation</example>
        [global::Newtonsoft.Json.JsonProperty("reported_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReportedType { get; set; } = default!;

        /// <summary>
        /// description of the model<br/>
        /// Example: ResNet-50 is a convolutional neural network that is trained on more than a million images from the ImageNet database. It is a 50-layer deep neural network.
        /// </summary>
        /// <example>ResNet-50 is a convolutional neural network that is trained on more than a million images from the ImageNet database. It is a 50-layer deep neural network.</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// cover image link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cover_img_url")]
        public string? CoverImgUrl { get; set; }

        /// <summary>
        /// list of tags
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The pricing type and cost for this model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pricing", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.ModelPricingTime, global::G.ModelPricingTokens, global::G.ModelPricingInputLength, global::G.ModelPricingInputTokens, global::G.ModelPricingUptime, global::G.ModelPricingInputCharacterLength, global::G.ModelPricingImageUnits> Pricing { get; set; } = default!;

        /// <summary>
        /// The maximum context size of this model, if applicable
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replaced_by")]
        public string? ReplacedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecated")]
        public int? Deprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantization")]
        public string? Quantization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mmlu")]
        public double? Mmlu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected")]
        public string? Expected { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private")]
        public int? Private { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelOut" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Model Name<br/>
        /// Example: microsoft/resnet-50
        /// </param>
        /// <param name="type">
        /// raw type of the model<br/>
        /// Example: image-classification
        /// </param>
        /// <param name="reportedType">
        /// reported type of the model<br/>
        /// Example: text-generation
        /// </param>
        /// <param name="description">
        /// description of the model<br/>
        /// Example: ResNet-50 is a convolutional neural network that is trained on more than a million images from the ImageNet database. It is a 50-layer deep neural network.
        /// </param>
        /// <param name="coverImgUrl">
        /// cover image link
        /// </param>
        /// <param name="tags">
        /// list of tags
        /// </param>
        /// <param name="pricing">
        /// The pricing type and cost for this model
        /// </param>
        /// <param name="maxTokens">
        /// The maximum context size of this model, if applicable
        /// </param>
        /// <param name="replacedBy"></param>
        /// <param name="deprecated"></param>
        /// <param name="quantization"></param>
        /// <param name="mmlu"></param>
        /// <param name="expected"></param>
        /// <param name="private">
        /// Default Value: 0
        /// </param>
        public ModelOut(
            string modelName,
            string type,
            string reportedType,
            global::G.AnyOf<global::G.ModelPricingTime, global::G.ModelPricingTokens, global::G.ModelPricingInputLength, global::G.ModelPricingInputTokens, global::G.ModelPricingUptime, global::G.ModelPricingInputCharacterLength, global::G.ModelPricingImageUnits> pricing,
            string? description,
            string? coverImgUrl,
            global::System.Collections.Generic.IList<string>? tags,
            int? maxTokens,
            string? replacedBy,
            int? deprecated,
            string? quantization,
            double? mmlu,
            string? expected,
            int? @private)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ReportedType = reportedType ?? throw new global::System.ArgumentNullException(nameof(reportedType));
            this.Pricing = pricing;
            this.Description = description;
            this.CoverImgUrl = coverImgUrl;
            this.Tags = tags;
            this.MaxTokens = maxTokens;
            this.ReplacedBy = replacedBy;
            this.Deprecated = deprecated;
            this.Quantization = quantization;
            this.Mmlu = mmlu;
            this.Expected = expected;
            this.Private = @private;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelOut" /> class.
        /// </summary>
        public ModelOut()
        {
        }
    }
}