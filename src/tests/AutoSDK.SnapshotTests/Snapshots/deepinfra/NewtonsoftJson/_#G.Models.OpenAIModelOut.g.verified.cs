//HintName: G.Models.OpenAIModelOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIModelOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Default Value: model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public int Created { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owned_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("root", Required = global::Newtonsoft.Json.Required.Always)]
        public string Root { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent")]
        public object? Parent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIModelOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: model
        /// </param>
        /// <param name="created"></param>
        /// <param name="ownedBy"></param>
        /// <param name="root"></param>
        /// <param name="parent"></param>
        public OpenAIModelOut(
            string id,
            int created,
            string ownedBy,
            string root,
            string? @object,
            object? parent)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Created = created;
            this.OwnedBy = ownedBy ?? throw new global::System.ArgumentNullException(nameof(ownedBy));
            this.Root = root ?? throw new global::System.ArgumentNullException(nameof(root));
            this.Object = @object;
            this.Parent = parent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIModelOut" /> class.
        /// </summary>
        public OpenAIModelOut()
        {
        }
    }
}