//HintName: G.Models.ResultReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reference to a result in a specific category.
    /// </summary>
    public sealed partial class ResultReference
    {
        /// <summary>
        /// The result type (e.g., web, videos, news, infobox).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Index of the result within its category.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Whether all results of this type should be included.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("all")]
        public bool? All { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultReference" /> class.
        /// </summary>
        /// <param name="type">
        /// The result type (e.g., web, videos, news, infobox).
        /// </param>
        /// <param name="index">
        /// Index of the result within its category.
        /// </param>
        /// <param name="all">
        /// Whether all results of this type should be included.
        /// </param>
        public ResultReference(
            string? type,
            int? index,
            bool? all)
        {
            this.Type = type;
            this.Index = index;
            this.All = all;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultReference" /> class.
        /// </summary>
        public ResultReference()
        {
        }
    }
}