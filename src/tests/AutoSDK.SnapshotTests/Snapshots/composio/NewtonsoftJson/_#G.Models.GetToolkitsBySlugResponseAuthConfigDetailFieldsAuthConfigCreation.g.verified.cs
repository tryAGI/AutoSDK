//HintName: G.Models.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Form fields needed when creating an authentication configuration
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem> Required { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optional", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem> Optional { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation" /> class.
        /// </summary>
        /// <param name="required"></param>
        /// <param name="optional"></param>
        public GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation(
            global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem> required,
            global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem> optional)
        {
            this.Required = required ?? throw new global::System.ArgumentNullException(nameof(required));
            this.Optional = optional ?? throw new global::System.ArgumentNullException(nameof(optional));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation()
        {
        }
    }
}