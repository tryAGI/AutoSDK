//HintName: G.Models.AlignmentConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"language":"en"}
    /// </summary>
    public sealed partial class AlignmentConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentConfig" /> class.
        /// </summary>
        /// <param name="language"></param>
        public AlignmentConfig(
            string language)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentConfig" /> class.
        /// </summary>
        public AlignmentConfig()
        {
        }
    }
}