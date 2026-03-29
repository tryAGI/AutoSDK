//HintName: G.Models.DescriptionAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// DescriptionAnnotation.
    /// </summary>
    public sealed partial class DescriptionAnnotation
    {
        /// <summary>
        /// Default Value: description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provenance", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provenance { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptionAnnotation" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="provenance"></param>
        /// <param name="kind">
        /// Default Value: description
        /// </param>
        public DescriptionAnnotation(
            string text,
            string provenance,
            string? kind)
        {
            this.Kind = kind;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Provenance = provenance ?? throw new global::System.ArgumentNullException(nameof(provenance));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptionAnnotation" /> class.
        /// </summary>
        public DescriptionAnnotation()
        {
        }
    }
}