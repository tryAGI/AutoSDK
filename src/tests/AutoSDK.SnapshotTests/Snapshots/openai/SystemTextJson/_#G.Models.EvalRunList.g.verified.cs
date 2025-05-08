//HintName: G.Models.EvalRunList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object representing a list of runs for an evaluation.
    /// </summary>
    public sealed partial class EvalRunList
    {
        /// <summary>
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </summary>
        /// <default>global::G.EvalRunListObject.List</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalRunListObjectJsonConverter))]
        public global::G.EvalRunListObject Object { get; set; } = global::G.EvalRunListObject.List;

        /// <summary>
        /// An array of eval run objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EvalRun> Data { get; set; }

        /// <summary>
        /// The identifier of the first eval run in the data array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstId { get; set; }

        /// <summary>
        /// The identifier of the last eval run in the data array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastId { get; set; }

        /// <summary>
        /// Indicates whether there are more evals available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunList" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </param>
        /// <param name="data">
        /// An array of eval run objects.
        /// </param>
        /// <param name="firstId">
        /// The identifier of the first eval run in the data array.
        /// </param>
        /// <param name="lastId">
        /// The identifier of the last eval run in the data array.
        /// </param>
        /// <param name="hasMore">
        /// Indicates whether there are more evals available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalRunList(
            global::System.Collections.Generic.IList<global::G.EvalRun> data,
            string firstId,
            string lastId,
            bool hasMore,
            global::G.EvalRunListObject @object = global::G.EvalRunListObject.List)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.HasMore = hasMore;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunList" /> class.
        /// </summary>
        public EvalRunList()
        {
        }
    }
}