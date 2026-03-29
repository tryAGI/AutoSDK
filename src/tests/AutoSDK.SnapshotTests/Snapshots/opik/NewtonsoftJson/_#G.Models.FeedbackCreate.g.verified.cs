//HintName: G.Models.FeedbackCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FeedbackCreate
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional description for the feedback definition<br/>
        /// Example: This feedback definition is used to rate response quality
        /// </summary>
        /// <example>This feedback definition is used to rate response quality</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Optional description for the feedback definition<br/>
        /// Example: This feedback definition is used to rate response quality
        /// </param>
        public FeedbackCreate(
            string name,
            global::System.Guid? id,
            string? description)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreate" /> class.
        /// </summary>
        public FeedbackCreate()
        {
        }
    }
}