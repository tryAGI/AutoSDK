//HintName: G.Models.CompletionChunk.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CompletionToken Token { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CompletionChoice> Choices { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AllOf<global::G.UsageData, object> Usage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AllOf<global::G.FinishReason?, object> FinishReason { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionChunk" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <param name="choices"></param>
        /// <param name="usage"></param>
        /// <param name="seed"></param>
        /// <param name="finishReason"></param>
        public CompletionChunk(
            string id,
            global::G.CompletionToken token,
            global::System.Collections.Generic.IList<global::G.CompletionChoice> choices,
            global::G.AllOf<global::G.UsageData, object> usage,
            global::G.AllOf<global::G.FinishReason?, object> finishReason,
            int? seed)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Usage = usage;
            this.FinishReason = finishReason;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionChunk" /> class.
        /// </summary>
        public CompletionChunk()
        {
        }
    }
}