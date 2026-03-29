//HintName: G.Models.ModelValueReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelValueReference
    {
        /// <summary>
        /// Reference to a value or rate.<br/>
        /// Examples:<br/>
        /// - `input_tokens`: Number of input tokens<br/>
        /// - `output_tokens`: Number of output tokens<br/>
        /// - `rates.request_token`: Request token rate<br/>
        /// - `rates.response_token`: Response token rate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelValueReference" /> class.
        /// </summary>
        /// <param name="value">
        /// Reference to a value or rate.<br/>
        /// Examples:<br/>
        /// - `input_tokens`: Number of input tokens<br/>
        /// - `output_tokens`: Number of output tokens<br/>
        /// - `rates.request_token`: Request token rate<br/>
        /// - `rates.response_token`: Response token rate
        /// </param>
        public ModelValueReference(
            string? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelValueReference" /> class.
        /// </summary>
        public ModelValueReference()
        {
        }
    }
}