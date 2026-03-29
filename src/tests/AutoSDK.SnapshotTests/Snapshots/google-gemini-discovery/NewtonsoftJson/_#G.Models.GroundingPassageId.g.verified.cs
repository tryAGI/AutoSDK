//HintName: G.Models.GroundingPassageId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifier for a part within a `GroundingPassage`.
    /// </summary>
    public sealed partial class GroundingPassageId
    {
        /// <summary>
        /// Output only. ID of the passage matching the `GenerateAnswerRequest`'s `GroundingPassage.id`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passageId")]
        public string? PassageId { get; set; }

        /// <summary>
        /// Output only. Index of the part within the `GenerateAnswerRequest`'s `GroundingPassage.content`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partIndex")]
        public int? PartIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingPassageId" /> class.
        /// </summary>
        /// <param name="passageId">
        /// Output only. ID of the passage matching the `GenerateAnswerRequest`'s `GroundingPassage.id`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="partIndex">
        /// Output only. Index of the part within the `GenerateAnswerRequest`'s `GroundingPassage.content`.<br/>
        /// Included only in responses
        /// </param>
        public GroundingPassageId(
            string? passageId,
            int? partIndex)
        {
            this.PassageId = passageId;
            this.PartIndex = partIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingPassageId" /> class.
        /// </summary>
        public GroundingPassageId()
        {
        }
    }
}