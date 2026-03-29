//HintName: G.Models.UpdatePromptVersionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePromptVersionRequest
    {
        /// <summary>
        /// The label to assign to this version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label_id")]
        public global::System.Guid? LabelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptVersionRequest" /> class.
        /// </summary>
        /// <param name="labelId">
        /// The label to assign to this version.
        /// </param>
        public UpdatePromptVersionRequest(
            global::System.Guid? labelId)
        {
            this.LabelId = labelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptVersionRequest" /> class.
        /// </summary>
        public UpdatePromptVersionRequest()
        {
        }
    }
}