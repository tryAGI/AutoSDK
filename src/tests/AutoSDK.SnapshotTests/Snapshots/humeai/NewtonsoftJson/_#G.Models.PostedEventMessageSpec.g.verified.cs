//HintName: G.Models.PostedEventMessageSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedEventMessageSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

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
        /// Initializes a new instance of the <see cref="PostedEventMessageSpec" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="text"></param>
        public PostedEventMessageSpec(
            bool? enabled,
            string? text)
        {
            this.Enabled = enabled;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedEventMessageSpec" /> class.
        /// </summary>
        public PostedEventMessageSpec()
        {
        }
    }
}