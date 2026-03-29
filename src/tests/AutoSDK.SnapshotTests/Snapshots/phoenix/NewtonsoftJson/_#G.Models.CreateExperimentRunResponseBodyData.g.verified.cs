//HintName: G.Models.CreateExperimentRunResponseBodyData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentRunResponseBodyData
    {
        /// <summary>
        /// The ID of the newly created experiment run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentRunResponseBodyData" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the newly created experiment run
        /// </param>
        public CreateExperimentRunResponseBodyData(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentRunResponseBodyData" /> class.
        /// </summary>
        public CreateExperimentRunResponseBodyData()
        {
        }
    }
}