//HintName: G.Models.EditImageGetLayersVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetLayersVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EditImageGetLayersVariant1Text Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant1" /> class.
        /// </summary>
        /// <param name="text"></param>
        public EditImageGetLayersVariant1(
            global::G.EditImageGetLayersVariant1Text text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant1" /> class.
        /// </summary>
        public EditImageGetLayersVariant1()
        {
        }
    }
}