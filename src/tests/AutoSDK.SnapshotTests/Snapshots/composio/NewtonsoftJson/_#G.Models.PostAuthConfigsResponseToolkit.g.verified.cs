//HintName: G.Models.PostAuthConfigsResponseToolkit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostAuthConfigsResponseToolkit
    {
        /// <summary>
        /// The unique key of the toolkit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsResponseToolkit" /> class.
        /// </summary>
        /// <param name="slug">
        /// The unique key of the toolkit
        /// </param>
        public PostAuthConfigsResponseToolkit(
            string slug)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsResponseToolkit" /> class.
        /// </summary>
        public PostAuthConfigsResponseToolkit()
        {
        }
    }
}