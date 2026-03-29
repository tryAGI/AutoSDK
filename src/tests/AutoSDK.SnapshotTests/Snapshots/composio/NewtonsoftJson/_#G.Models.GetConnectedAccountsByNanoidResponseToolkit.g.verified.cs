//HintName: G.Models.GetConnectedAccountsByNanoidResponseToolkit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseToolkit
    {
        /// <summary>
        /// The slug of the toolkit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseToolkit" /> class.
        /// </summary>
        /// <param name="slug">
        /// The slug of the toolkit
        /// </param>
        public GetConnectedAccountsByNanoidResponseToolkit(
            string slug)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseToolkit" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseToolkit()
        {
        }
    }
}