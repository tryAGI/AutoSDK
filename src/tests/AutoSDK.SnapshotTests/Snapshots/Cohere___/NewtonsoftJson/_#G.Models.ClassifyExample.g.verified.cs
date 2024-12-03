//HintName: G.Models.ClassifyExample.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in requests
    /// </summary>
    public sealed partial class ClassifyExample
    {
        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyExample" /> class.
        /// </summary>
        /// <param name="text">
        /// Included only in requests
        /// </param>
        /// <param name="label">
        /// Included only in requests
        /// </param>
        public ClassifyExample(
            string? text,
            string? label)
        {
            this.Text = text;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyExample" /> class.
        /// </summary>
        public ClassifyExample()
        {
        }
    }
}