//HintName: G.Models.PostAuthConfigsRequestToolkit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostAuthConfigsRequestToolkit
    {
        /// <summary>
        /// Toolkit slug to create auth config for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequestToolkit" /> class.
        /// </summary>
        /// <param name="slug">
        /// Toolkit slug to create auth config for
        /// </param>
        public PostAuthConfigsRequestToolkit(
            string slug)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequestToolkit" /> class.
        /// </summary>
        public PostAuthConfigsRequestToolkit()
        {
        }
    }
}