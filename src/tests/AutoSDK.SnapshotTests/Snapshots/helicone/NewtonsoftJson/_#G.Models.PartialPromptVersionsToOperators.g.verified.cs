//HintName: G.Models.PartialPromptVersionsToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialPromptVersionsToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minor_version")]
        public global::G.PartialNumberOperators? MinorVersion { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("major_version")]
        public global::G.PartialNumberOperators? MajorVersion { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.PartialTextOperators? Id { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_v2")]
        public global::G.PartialTextOperators? PromptV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPromptVersionsToOperators" /> class.
        /// </summary>
        /// <param name="minorVersion">
        /// Make all properties in T optional
        /// </param>
        /// <param name="majorVersion">
        /// Make all properties in T optional
        /// </param>
        /// <param name="id">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptV2">
        /// Make all properties in T optional
        /// </param>
        public PartialPromptVersionsToOperators(
            global::G.PartialNumberOperators? minorVersion,
            global::G.PartialNumberOperators? majorVersion,
            global::G.PartialTextOperators? id,
            global::G.PartialTextOperators? promptV2)
        {
            this.MinorVersion = minorVersion;
            this.MajorVersion = majorVersion;
            this.Id = id;
            this.PromptV2 = promptV2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPromptVersionsToOperators" /> class.
        /// </summary>
        public PartialPromptVersionsToOperators()
        {
        }
    }
}