//HintName: G.Models.StreamResponseEnd.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The end of a query response stream.
    /// </summary>
    public sealed partial class StreamResponseEnd
    {
        /// <summary>
        /// Then end of stream will be denoted with an object<br/>
        /// with the type `end`.<br/>
        /// Default Value: end
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamResponseEnd" /> class.
        /// </summary>
        /// <param name="type">
        /// Then end of stream will be denoted with an object<br/>
        /// with the type `end`.<br/>
        /// Default Value: end
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StreamResponseEnd(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamResponseEnd" /> class.
        /// </summary>
        public StreamResponseEnd()
        {
        }
    }
}