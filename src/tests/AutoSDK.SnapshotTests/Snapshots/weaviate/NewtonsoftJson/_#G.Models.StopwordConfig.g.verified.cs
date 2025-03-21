﻿//HintName: G.Models.StopwordConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// fine-grained control over stopword list usage
    /// </summary>
    public sealed partial class StopwordConfig
    {
        /// <summary>
        /// pre-existing list of common words by language<br/>
        /// Default Value: en
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preset")]
        public global::G.StopwordConfigPreset? Preset { get; set; }

        /// <summary>
        /// Stopwords to be considered additionally. Can be any array of custom strings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additions")]
        public global::System.Collections.Generic.IList<string>? Additions { get; set; }

        /// <summary>
        /// stopwords to be removed from consideration. Can be any array of custom strings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("removals")]
        public global::System.Collections.Generic.IList<string>? Removals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopwordConfig" /> class.
        /// </summary>
        /// <param name="preset">
        /// pre-existing list of common words by language<br/>
        /// Default Value: en
        /// </param>
        /// <param name="additions">
        /// Stopwords to be considered additionally. Can be any array of custom strings.
        /// </param>
        /// <param name="removals">
        /// stopwords to be removed from consideration. Can be any array of custom strings.
        /// </param>
        public StopwordConfig(
            global::G.StopwordConfigPreset? preset,
            global::System.Collections.Generic.IList<string>? additions,
            global::System.Collections.Generic.IList<string>? removals)
        {
            this.Preset = preset;
            this.Additions = additions;
            this.Removals = removals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopwordConfig" /> class.
        /// </summary>
        public StopwordConfig()
        {
        }
    }
}