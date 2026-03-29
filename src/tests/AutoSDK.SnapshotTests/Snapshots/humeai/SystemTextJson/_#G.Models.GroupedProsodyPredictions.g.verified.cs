//HintName: G.Models.GroupedProsodyPredictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupedProsodyPredictions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        public global::System.Collections.Generic.IList<global::G.ProsodyPrediction>? Predictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedProsodyPredictions" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="predictions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupedProsodyPredictions(
            string? id,
            global::System.Collections.Generic.IList<global::G.ProsodyPrediction>? predictions)
        {
            this.Id = id;
            this.Predictions = predictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedProsodyPredictions" /> class.
        /// </summary>
        public GroupedProsodyPredictions()
        {
        }
    }
}