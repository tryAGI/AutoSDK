//HintName: G.Models.CreateRequestKnowledge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Knowledge Base used by the Agent to retrieve answers (RAG).<br/>
    /// Use the ID returned by the Create Knowledge endpoint.
    /// </summary>
    public sealed partial class CreateRequestKnowledge
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequestKnowledge" /> class.
        /// </summary>
        /// <param name="id"></param>
        public CreateRequestKnowledge(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequestKnowledge" /> class.
        /// </summary>
        public CreateRequestKnowledge()
        {
        }
    }
}