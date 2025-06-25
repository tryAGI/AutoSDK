//HintName: G.Models.SummarizeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarizeRequest
    {
        /// <summary>
        /// A free-form instruction for modifying how the summaries get generated. Should complete the sentence "Generate a summary _". Eg. "focusing on the next steps" or "written by Yoda"<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_command")]
        public string? AdditionalCommand { get; set; }

        /// <summary>
        /// One of `low`, `medium`, `high`, or `auto`, defaults to `auto`. Controls how close to the original text the summary is. `high` extractiveness summaries will lean towards reusing sentences verbatim, while `low` extractiveness summaries will tend to paraphrase more. If `auto` is selected, the best option will be picked based on the input text.<br/>
        /// Default Value: low<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extractiveness")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SummarizeRequestExtractivenessJsonConverter))]
        public global::G.SummarizeRequestExtractiveness? Extractiveness { get; set; }

        /// <summary>
        /// One of `paragraph`, `bullets`, or `auto`, defaults to `auto`. Indicates the style in which the summary will be delivered - in a free form paragraph or in bullet points. If `auto` is selected, the best option will be picked based on the input text.<br/>
        /// Default Value: paragraph<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SummarizeRequestFormatJsonConverter))]
        public global::G.SummarizeRequestFormat? Format { get; set; }

        /// <summary>
        /// One of `short`, `medium`, `long`, or `auto` defaults to `auto`. Indicates the approximate length of the summary. If `auto` is selected, the best option will be picked based on the input text.<br/>
        /// Default Value: medium<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SummarizeRequestLengthJsonConverter))]
        public global::G.SummarizeRequestLength? Length { get; set; }

        /// <summary>
        /// The identifier of the model to generate the summary with. Currently available models are `command` (default), `command-nightly` (experimental), `command-light`, and `command-light-nightly` (experimental). Smaller, "light" models are faster, while larger models will perform better.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Ranges from 0 to 5. Controls the randomness of the output. Lower values tend to generate more “predictable” output, while higher values tend to generate more “creative” output. The sweet spot is typically between 0 and 1.<br/>
        /// Default Value: 0.3<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The text to generate a summary for. Can be up to 100,000 characters long. Currently the only supported language is English.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeRequest" /> class.
        /// </summary>
        /// <param name="additionalCommand">
        /// A free-form instruction for modifying how the summaries get generated. Should complete the sentence "Generate a summary _". Eg. "focusing on the next steps" or "written by Yoda"<br/>
        /// Included only in requests
        /// </param>
        /// <param name="extractiveness">
        /// One of `low`, `medium`, `high`, or `auto`, defaults to `auto`. Controls how close to the original text the summary is. `high` extractiveness summaries will lean towards reusing sentences verbatim, while `low` extractiveness summaries will tend to paraphrase more. If `auto` is selected, the best option will be picked based on the input text.<br/>
        /// Default Value: low<br/>
        /// Included only in requests
        /// </param>
        /// <param name="format">
        /// One of `paragraph`, `bullets`, or `auto`, defaults to `auto`. Indicates the style in which the summary will be delivered - in a free form paragraph or in bullet points. If `auto` is selected, the best option will be picked based on the input text.<br/>
        /// Default Value: paragraph<br/>
        /// Included only in requests
        /// </param>
        /// <param name="length">
        /// One of `short`, `medium`, `long`, or `auto` defaults to `auto`. Indicates the approximate length of the summary. If `auto` is selected, the best option will be picked based on the input text.<br/>
        /// Default Value: medium<br/>
        /// Included only in requests
        /// </param>
        /// <param name="model">
        /// The identifier of the model to generate the summary with. Currently available models are `command` (default), `command-nightly` (experimental), `command-light`, and `command-light-nightly` (experimental). Smaller, "light" models are faster, while larger models will perform better.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="temperature">
        /// Ranges from 0 to 5. Controls the randomness of the output. Lower values tend to generate more “predictable” output, while higher values tend to generate more “creative” output. The sweet spot is typically between 0 and 1.<br/>
        /// Default Value: 0.3<br/>
        /// Included only in requests
        /// </param>
        /// <param name="text">
        /// The text to generate a summary for. Can be up to 100,000 characters long. Currently the only supported language is English.<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarizeRequest(
            string? additionalCommand,
            global::G.SummarizeRequestExtractiveness? extractiveness,
            global::G.SummarizeRequestFormat? format,
            global::G.SummarizeRequestLength? length,
            string? model,
            double? temperature,
            string? text)
        {
            this.AdditionalCommand = additionalCommand;
            this.Extractiveness = extractiveness;
            this.Format = format;
            this.Length = length;
            this.Model = model;
            this.Temperature = temperature;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeRequest" /> class.
        /// </summary>
        public SummarizeRequest()
        {
        }
    }
}