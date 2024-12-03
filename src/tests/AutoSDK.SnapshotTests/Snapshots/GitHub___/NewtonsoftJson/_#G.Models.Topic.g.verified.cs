//HintName: G.Models.Topic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A topic aggregates entities that are related to a subject.
    /// </summary>
    public sealed partial class Topic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("names", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Names { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Topic" /> class.
        /// </summary>
        /// <param name="names"></param>
        public Topic(
            global::System.Collections.Generic.IList<string> names)
        {
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Topic" /> class.
        /// </summary>
        public Topic()
        {
        }
    }
}