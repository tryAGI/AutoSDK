//HintName: G.Models.ResearchDtoClassVariant3Output.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassVariant3Output
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parsed")]
        public object? Parsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant3Output" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="parsed"></param>
        public ResearchDtoClassVariant3Output(
            string content,
            object? parsed)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Parsed = parsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant3Output" /> class.
        /// </summary>
        public ResearchDtoClassVariant3Output()
        {
        }
    }
}