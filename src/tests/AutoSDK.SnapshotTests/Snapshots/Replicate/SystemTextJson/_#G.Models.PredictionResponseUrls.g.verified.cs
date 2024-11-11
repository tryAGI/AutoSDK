//HintName: G.Models.PredictionResponseUrls.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionResponseUrls
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("get")]
        public string? Get { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel")]
        public string? Cancel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionResponseUrls" /> class.
        /// </summary>
        /// <param name="get"></param>
        /// <param name="cancel"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PredictionResponseUrls(
            string? get,
            string? cancel)
        {
            this.Get = get;
            this.Cancel = cancel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionResponseUrls" /> class.
        /// </summary>
        public PredictionResponseUrls()
        {
        }
    }
}