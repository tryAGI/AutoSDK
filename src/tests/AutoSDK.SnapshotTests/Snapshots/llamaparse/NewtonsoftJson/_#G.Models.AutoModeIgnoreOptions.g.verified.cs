//HintName: G.Models.AutoModeIgnoreOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Ignore options for auto mode parsing configuration.
    /// </summary>
    public sealed partial class AutoModeIgnoreOptions
    {
        /// <summary>
        /// Whether to ignore diagonal text in the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignore_diagonal_text")]
        public bool? IgnoreDiagonalText { get; set; }

        /// <summary>
        /// Whether to ignore hidden text in the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignore_hidden_text")]
        public bool? IgnoreHiddenText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModeIgnoreOptions" /> class.
        /// </summary>
        /// <param name="ignoreDiagonalText">
        /// Whether to ignore diagonal text in the document
        /// </param>
        /// <param name="ignoreHiddenText">
        /// Whether to ignore hidden text in the document
        /// </param>
        public AutoModeIgnoreOptions(
            bool? ignoreDiagonalText,
            bool? ignoreHiddenText)
        {
            this.IgnoreDiagonalText = ignoreDiagonalText;
            this.IgnoreHiddenText = ignoreHiddenText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModeIgnoreOptions" /> class.
        /// </summary>
        public AutoModeIgnoreOptions()
        {
        }
    }
}