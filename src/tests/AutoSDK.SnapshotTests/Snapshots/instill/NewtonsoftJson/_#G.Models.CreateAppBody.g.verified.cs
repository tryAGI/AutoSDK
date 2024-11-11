//HintName: G.Models.CreateAppBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CreateAppRequest represents a request to create a app.
    /// </summary>
    public sealed partial class CreateAppBody
    {
        /// <summary>
        /// The app id.<br/>
        /// the app id should be lowercase without any space or special character besides the hyphen,<br/>
        /// it can not start with number or hyphen, and should be less than 32 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The app description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The app tags.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAppBody" /> class.
        /// </summary>
        /// <param name="id">
        /// The app id.<br/>
        /// the app id should be lowercase without any space or special character besides the hyphen,<br/>
        /// it can not start with number or hyphen, and should be less than 32 characters.
        /// </param>
        /// <param name="description">
        /// The app description.
        /// </param>
        /// <param name="tags">
        /// The app tags.
        /// </param>
        public CreateAppBody(
            string id,
            string? description,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Description = description;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAppBody" /> class.
        /// </summary>
        public CreateAppBody()
        {
        }
    }
}