//HintName: G.Models.PostedConfigPromptSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedConfigPromptSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedConfigPromptSpec" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="text"></param>
        public PostedConfigPromptSpec(
            string? id,
            int? version,
            string? text)
        {
            this.Id = id;
            this.Version = version;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedConfigPromptSpec" /> class.
        /// </summary>
        public PostedConfigPromptSpec()
        {
        }
    }
}