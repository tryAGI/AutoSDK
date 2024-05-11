//HintName: G.Models.CreateModerationResponseResultsCategoryScores.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of the categories along with their scores as predicted by model.
    /// </summary>
    public sealed partial class CreateModerationResponseResultsCategoryScores
    {
        /// <summary>
        /// The score for the category 'hate'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hate", Required = global::Newtonsoft.Json.Required.Always)]
        public double Hate { get; set; } = default!;

        /// <summary>
        /// The score for the category 'hate/threatening'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hate/threatening", Required = global::Newtonsoft.Json.Required.Always)]
        public double HateThreatening { get; set; } = default!;

        /// <summary>
        /// The score for the category 'harassment'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("harassment", Required = global::Newtonsoft.Json.Required.Always)]
        public double Harassment { get; set; } = default!;

        /// <summary>
        /// The score for the category 'harassment/threatening'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("harassment/threatening", Required = global::Newtonsoft.Json.Required.Always)]
        public double HarassmentThreatening { get; set; } = default!;

        /// <summary>
        /// The score for the category 'self-harm'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self-harm", Required = global::Newtonsoft.Json.Required.Always)]
        public double SelfHarm { get; set; } = default!;

        /// <summary>
        /// The score for the category 'self-harm/intent'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self-harm/intent", Required = global::Newtonsoft.Json.Required.Always)]
        public double SelfHarmIntent { get; set; } = default!;

        /// <summary>
        /// The score for the category 'self-harm/instructions'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self-harm/instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public double SelfHarmInstructions { get; set; } = default!;

        /// <summary>
        /// The score for the category 'sexual'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sexual", Required = global::Newtonsoft.Json.Required.Always)]
        public double Sexual { get; set; } = default!;

        /// <summary>
        /// The score for the category 'sexual/minors'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sexual/minors", Required = global::Newtonsoft.Json.Required.Always)]
        public double SexualMinors { get; set; } = default!;

        /// <summary>
        /// The score for the category 'violence'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("violence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Violence { get; set; } = default!;

        /// <summary>
        /// The score for the category 'violence/graphic'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("violence/graphic", Required = global::Newtonsoft.Json.Required.Always)]
        public double ViolenceGraphic { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}