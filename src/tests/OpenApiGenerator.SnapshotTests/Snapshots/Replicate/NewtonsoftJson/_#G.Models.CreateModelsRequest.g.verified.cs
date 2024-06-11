//HintName: G.Models.CreateModelsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelsRequest
    {
        /// <summary>
        /// A URL for the model's cover image. This should be an image file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// A description of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A URL for the model's source code on GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("github_url")]
        public string? GithubUrl { get; set; }

        /// <summary>
        /// The SKU for the hardware used to run the model. Possible values can be retrieved from the `hardware.list` endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hardware", Required = global::Newtonsoft.Json.Required.Always)]
        public string Hardware { get; set; } = default!;

        /// <summary>
        /// A URL for the model's license.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license_url")]
        public string? LicenseUrl { get; set; }

        /// <summary>
        /// The name of the model. This must be unique among all models owned by the user or organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The name of the user or organization that will own the model. This must be the same as the user or organization that is making the API request. In other words, the API token used in the request must belong to this user or organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public string Owner { get; set; } = default!;

        /// <summary>
        /// A URL for the model's paper.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("paper_url")]
        public string? PaperUrl { get; set; }

        /// <summary>
        /// Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateModelsRequestVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}