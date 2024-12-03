//HintName: G.Models.CreateTranslationResponseJson.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranslationResponseJson
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationResponseJson" /> class.
        /// </summary>
        /// <param name="text"></param>
        public CreateTranslationResponseJson(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationResponseJson" /> class.
        /// </summary>
        public CreateTranslationResponseJson()
        {
        }
    }
}