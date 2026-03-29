//HintName: G.Models.LabelDistributionStructureDimension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabelDistributionStructureDimension
    {
        /// <summary>
        /// Flat keys in "&lt;from_name&gt;___SEP___&lt;choice&gt;" format for this dimension.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("choice_keys")]
        public string ChoiceKeys { get; set; } = default!;

        /// <summary>
        /// Sorted list of choices observed from config and/or created labels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Choices { get; set; } = default!;

        /// <summary>
        /// Original from_name from labeling config or observed annotation results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Result item type for this dimension when available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionStructureDimension" /> class.
        /// </summary>
        /// <param name="choices">
        /// Sorted list of choices observed from config and/or created labels.
        /// </param>
        /// <param name="name">
        /// Original from_name from labeling config or observed annotation results.
        /// </param>
        /// <param name="type">
        /// Result item type for this dimension when available.
        /// </param>
        /// <param name="choiceKeys">
        /// Flat keys in "&lt;from_name&gt;___SEP___&lt;choice&gt;" format for this dimension.<br/>
        /// Included only in responses
        /// </param>
        public LabelDistributionStructureDimension(
            global::System.Collections.Generic.IList<string> choices,
            string name,
            string? type,
            string choiceKeys = default!)
        {
            this.ChoiceKeys = choiceKeys;
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionStructureDimension" /> class.
        /// </summary>
        public LabelDistributionStructureDimension()
        {
        }
    }
}