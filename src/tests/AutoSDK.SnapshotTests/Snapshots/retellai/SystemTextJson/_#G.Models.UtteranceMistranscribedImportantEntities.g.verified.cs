//HintName: G.Models.UtteranceMistranscribedImportantEntities.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UtteranceMistranscribedImportantEntities
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UtteranceMistranscribedImportantEntitiesDetail> Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceMistranscribedImportantEntities" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtteranceMistranscribedImportantEntities(
            double responseId,
            global::System.Collections.Generic.IList<global::G.UtteranceMistranscribedImportantEntitiesDetail> details)
        {
            this.ResponseId = responseId;
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceMistranscribedImportantEntities" /> class.
        /// </summary>
        public UtteranceMistranscribedImportantEntities()
        {
        }
    }
}