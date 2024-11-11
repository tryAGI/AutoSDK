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
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Example: 128
        /// </summary>
        /// <example>128</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniques")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Uniques { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clones")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Traffic> Clones { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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