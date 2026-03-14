//HintName: G.Models.CompactionStartedEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompactionStartedEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: compaction_started<br/>
        /// Example: compaction_started
        /// </summary>
        /// <default>"compaction_started"</default>
        /// <example>compaction_started</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionStartedEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: compaction_started<br/>
        /// Example: compaction_started
        /// </param>
        public CompactionStartedEventVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionStartedEventVariant2" /> class.
        /// </summary>
        public CompactionStartedEventVariant2()
        {
        }
    }
}