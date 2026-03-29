//HintName: G.Models.ResearchOperationDtoClassVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchOperationDtoClassVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResearchOperationDtoClassVariant3TypeJsonConverter))]
        public global::G.ResearchOperationDtoClassVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goal")]
        public string? Goal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResearchOperationDtoClassVariant3Result Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOperationDtoClassVariant3" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="pageTokens"></param>
        /// <param name="type"></param>
        /// <param name="goal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchOperationDtoClassVariant3(
            global::G.ResearchOperationDtoClassVariant3Result result,
            double pageTokens,
            global::G.ResearchOperationDtoClassVariant3Type type,
            string? goal)
        {
            this.Type = type;
            this.Goal = goal;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.PageTokens = pageTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOperationDtoClassVariant3" /> class.
        /// </summary>
        public ResearchOperationDtoClassVariant3()
        {
        }
    }
}