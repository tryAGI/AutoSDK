//HintName: G.Models.CloneTraffic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Clone Traffic
    /// </summary>
    public sealed partial class CloneTraffic
    {
        /// <summary>
        /// Example: 173
        /// </summary>
        /// <example>173</example>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Example: 128
        /// </summary>
        /// <example>128</example>
        [global::Newtonsoft.Json.JsonProperty("uniques", Required = global::Newtonsoft.Json.Required.Always)]
        public int Uniques { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clones", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Traffic> Clones { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneTraffic" /> class.
        /// </summary>
        /// <param name="count">
        /// Example: 173
        /// </param>
        /// <param name="uniques">
        /// Example: 128
        /// </param>
        /// <param name="clones"></param>
        public CloneTraffic(
            int count,
            int uniques,
            global::System.Collections.Generic.IList<global::G.Traffic> clones)
        {
            this.Count = count;
            this.Uniques = uniques;
            this.Clones = clones ?? throw new global::System.ArgumentNullException(nameof(clones));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneTraffic" /> class.
        /// </summary>
        public CloneTraffic()
        {
        }
    }
}