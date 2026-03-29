//HintName: G.Models.PictureDescriptionLocal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PictureDescriptionLocal
    {
        /// <summary>
        /// Repository id from the Hugging Face Hub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepoId { get; set; } = default!;

        /// <summary>
        /// Prompt used when calling the vision-language model.<br/>
        /// Default Value: Describe this image in a few sentences.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Config from https://huggingface.co/docs/transformers/en/main_classes/text_generation#transformers.GenerationConfig<br/>
        /// Default Value: {"max_new_tokens":200,"do_sample":false}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_config")]
        public object? GenerationConfig { get; set; }

        /// <summary>
        /// Only describe pictures whose predicted class is in this allow-list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_allow")]
        public global::System.Collections.Generic.IList<global::G.PictureClassificationLabel>? ClassificationAllow { get; set; }

        /// <summary>
        /// Do not describe pictures whose predicted class is in this deny-list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_deny")]
        public global::System.Collections.Generic.IList<global::G.PictureClassificationLabel>? ClassificationDeny { get; set; }

        /// <summary>
        /// Minimum classification confidence required before a picture can be described.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_min_confidence")]
        public double? ClassificationMinConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureDescriptionLocal" /> class.
        /// </summary>
        /// <param name="repoId">
        /// Repository id from the Hugging Face Hub.
        /// </param>
        /// <param name="prompt">
        /// Prompt used when calling the vision-language model.<br/>
        /// Default Value: Describe this image in a few sentences.
        /// </param>
        /// <param name="generationConfig">
        /// Config from https://huggingface.co/docs/transformers/en/main_classes/text_generation#transformers.GenerationConfig<br/>
        /// Default Value: {"max_new_tokens":200,"do_sample":false}
        /// </param>
        /// <param name="classificationAllow">
        /// Only describe pictures whose predicted class is in this allow-list.
        /// </param>
        /// <param name="classificationDeny">
        /// Do not describe pictures whose predicted class is in this deny-list.
        /// </param>
        /// <param name="classificationMinConfidence">
        /// Minimum classification confidence required before a picture can be described.<br/>
        /// Default Value: 0F
        /// </param>
        public PictureDescriptionLocal(
            string repoId,
            string? prompt,
            object? generationConfig,
            global::System.Collections.Generic.IList<global::G.PictureClassificationLabel>? classificationAllow,
            global::System.Collections.Generic.IList<global::G.PictureClassificationLabel>? classificationDeny,
            double? classificationMinConfidence)
        {
            this.RepoId = repoId ?? throw new global::System.ArgumentNullException(nameof(repoId));
            this.Prompt = prompt;
            this.GenerationConfig = generationConfig;
            this.ClassificationAllow = classificationAllow;
            this.ClassificationDeny = classificationDeny;
            this.ClassificationMinConfidence = classificationMinConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureDescriptionLocal" /> class.
        /// </summary>
        public PictureDescriptionLocal()
        {
        }
    }
}