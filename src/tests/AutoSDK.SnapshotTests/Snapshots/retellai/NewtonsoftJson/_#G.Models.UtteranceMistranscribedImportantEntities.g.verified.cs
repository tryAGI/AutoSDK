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
        [global::Newtonsoft.Json.JsonProperty("response_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double ResponseId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UtteranceMistranscribedImportantEntitiesDetail> Details { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceMistranscribedImportantEntities" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="details"></param>
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