//HintName: G.Models.Image.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: [{"base64":"...very long string...","finishReason":"SUCCESS","seed":1050625087}, {"base64":"...very long string...","finishReason":"CONTENT_FILTERED","seed":1229191277}]
    /// </summary>
    public sealed partial class Image
    {
        /// <summary>
        /// Image encoded in base64<br/>
        /// Example: Sed corporis modi et.
        /// </summary>
        /// <example>Sed corporis modi et.</example>
        [global::Newtonsoft.Json.JsonProperty("base64")]
        public string? Base64 { get; set; }

        /// <summary>
        /// Example: CONTENT_FILTERED
        /// </summary>
        /// <example>CONTENT_FILTERED</example>
        [global::Newtonsoft.Json.JsonProperty("finishReason")]
        public global::G.ImageFinishReason? FinishReason { get; set; }

        /// <summary>
        /// The seed associated with this image<br/>
        /// Example: 1229191277
        /// </summary>
        /// <example>1229191277</example>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="base64">
        /// Image encoded in base64<br/>
        /// Example: Sed corporis modi et.
        /// </param>
        /// <param name="finishReason">
        /// Example: CONTENT_FILTERED
        /// </param>
        /// <param name="seed">
        /// The seed associated with this image<br/>
        /// Example: 1229191277
        /// </param>
        public Image(
            string? base64,
            global::G.ImageFinishReason? finishReason,
            double? seed)
        {
            this.Base64 = base64;
            this.FinishReason = finishReason;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        public Image()
        {
        }
    }
}