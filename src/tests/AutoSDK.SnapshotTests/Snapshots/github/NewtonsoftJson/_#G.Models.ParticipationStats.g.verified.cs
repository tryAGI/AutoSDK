//HintName: G.Models.ParticipationStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParticipationStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("all", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> All { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Owner { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipationStats" /> class.
        /// </summary>
        /// <param name="all"></param>
        /// <param name="owner"></param>
        public ParticipationStats(
            global::System.Collections.Generic.IList<int> all,
            global::System.Collections.Generic.IList<int> owner)
        {
            this.All = all ?? throw new global::System.ArgumentNullException(nameof(all));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipationStats" /> class.
        /// </summary>
        public ParticipationStats()
        {
        }
    }
}