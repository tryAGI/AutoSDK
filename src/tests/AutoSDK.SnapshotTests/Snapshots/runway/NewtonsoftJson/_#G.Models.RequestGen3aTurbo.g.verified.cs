//HintName: G.Models.RequestGen3aTurbo.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestGen3aTurbo
    {
        /// <summary>
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.<br/>
        /// Example: A beautiful sunset over a calm ocean.
        /// </summary>
        /// <example>A beautiful sunset over a calm ocean.</example>
        [global::Newtonsoft.Json.JsonProperty("promptText", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptText { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptImage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string?, global::System.Collections.Generic.IList<global::G.RequestGen3aTurboPromptImagePromptImage>> PromptImage { get; set; } = default!;

        /// <summary>
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The duration of the output video in seconds.<br/>
        /// Default Value: 10<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video.<br/>
        /// Example: 1280:768
        /// </summary>
        /// <example>1280:768</example>
        [global::Newtonsoft.Json.JsonProperty("ratio")]
        public global::G.RequestGen3aTurboRatio? Ratio { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.<br/>
        /// Example: {"publicFigureThreshold":"auto"}
        /// </summary>
        /// <example>{"publicFigureThreshold":"auto"}</example>
        [global::Newtonsoft.Json.JsonProperty("contentModeration")]
        public global::G.RequestGen3aTurboContentModeration? ContentModeration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"gen3a_turbo"</default>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string Model { get; set; } = "gen3a_turbo";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestGen3aTurbo" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.<br/>
        /// Example: A beautiful sunset over a calm ocean.
        /// </param>
        /// <param name="promptImage"></param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="duration">
        /// The duration of the output video in seconds.<br/>
        /// Default Value: 10<br/>
        /// Example: 5
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.<br/>
        /// Example: 1280:768
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.<br/>
        /// Example: {"publicFigureThreshold":"auto"}
        /// </param>
        /// <param name="model"></param>
        public RequestGen3aTurbo(
            string promptText,
            global::G.AnyOf<string?, global::System.Collections.Generic.IList<global::G.RequestGen3aTurboPromptImagePromptImage>> promptImage,
            int? seed,
            double? duration,
            global::G.RequestGen3aTurboRatio? ratio,
            global::G.RequestGen3aTurboContentModeration? contentModeration,
            string model = "gen3a_turbo")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.PromptImage = promptImage;
            this.Seed = seed;
            this.Duration = duration;
            this.Ratio = ratio;
            this.ContentModeration = contentModeration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestGen3aTurbo" /> class.
        /// </summary>
        public RequestGen3aTurbo()
        {
        }
    }
}