//HintName: G.Models.LabelDistributionStructureResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabelDistributionStructureResponse
    {
        /// <summary>
        /// All project choice keys in stable order, joined with "___PIPE___" when passed as query param.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("choice_keys")]
        public string ChoiceKeys { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dimensions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LabelDistributionStructureDimension> Dimensions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionStructureResponse" /> class.
        /// </summary>
        /// <param name="dimensions"></param>
        /// <param name="choiceKeys">
        /// All project choice keys in stable order, joined with "___PIPE___" when passed as query param.<br/>
        /// Included only in responses
        /// </param>
        public LabelDistributionStructureResponse(
            global::System.Collections.Generic.IList<global::G.LabelDistributionStructureDimension> dimensions,
            string choiceKeys = default!)
        {
            this.ChoiceKeys = choiceKeys;
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionStructureResponse" /> class.
        /// </summary>
        public LabelDistributionStructureResponse()
        {
        }
    }
}