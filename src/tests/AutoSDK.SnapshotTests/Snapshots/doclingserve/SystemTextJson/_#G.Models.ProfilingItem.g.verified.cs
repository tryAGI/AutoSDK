//HintName: G.Models.ProfilingItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProfilingItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProfilingScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProfilingScope Scope { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("times")]
        public global::System.Collections.Generic.IList<double>? Times { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamps")]
        public global::System.Collections.Generic.IList<global::System.DateTime>? StartTimestamps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilingItem" /> class.
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="count">
        /// Default Value: 0
        /// </param>
        /// <param name="times">
        /// Default Value: []
        /// </param>
        /// <param name="startTimestamps">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilingItem(
            global::G.ProfilingScope scope,
            int? count,
            global::System.Collections.Generic.IList<double>? times,
            global::System.Collections.Generic.IList<global::System.DateTime>? startTimestamps)
        {
            this.Scope = scope;
            this.Count = count;
            this.Times = times;
            this.StartTimestamps = startTimestamps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilingItem" /> class.
        /// </summary>
        public ProfilingItem()
        {
        }
    }
}