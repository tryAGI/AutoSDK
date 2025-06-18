//HintName: G.Models.CreateEvalResponsesRunDataSourceSamplingParamsText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for a text response from the model. Can be plain<br/>
    /// text or structured JSON data. Learn more:<br/>
    /// - [Text inputs and outputs](/docs/guides/text)<br/>
    /// - [Structured Outputs](/docs/guides/structured-outputs)
    /// </summary>
    public sealed partial class CreateEvalResponsesRunDataSourceSamplingParamsText
    {
        /// <summary>
        /// An object specifying the format that the model must output.<br/>
        /// Configuring `{ "type": "json_schema" }` enables Structured Outputs, <br/>
        /// which ensures the model will match your supplied JSON schema. Learn more in the <br/>
        /// [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// The default format is `{ "type": "text" }` with no additional options.<br/>
        /// **Not recommended for gpt-4o and newer models:**<br/>
        /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
        /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
        /// is preferred for models that support it.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.TextResponseFormatConfiguration? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSourceSamplingParamsText" /> class.
        /// </summary>
        /// <param name="format">
        /// An object specifying the format that the model must output.<br/>
        /// Configuring `{ "type": "json_schema" }` enables Structured Outputs, <br/>
        /// which ensures the model will match your supplied JSON schema. Learn more in the <br/>
        /// [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// The default format is `{ "type": "text" }` with no additional options.<br/>
        /// **Not recommended for gpt-4o and newer models:**<br/>
        /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
        /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
        /// is preferred for models that support it.
        /// </param>
        public CreateEvalResponsesRunDataSourceSamplingParamsText(
            global::G.TextResponseFormatConfiguration? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSourceSamplingParamsText" /> class.
        /// </summary>
        public CreateEvalResponsesRunDataSourceSamplingParamsText()
        {
        }
    }
}