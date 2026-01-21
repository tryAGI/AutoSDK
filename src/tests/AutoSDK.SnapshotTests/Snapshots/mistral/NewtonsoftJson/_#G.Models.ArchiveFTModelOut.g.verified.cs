//HintName: G.Models.ArchiveFTModelOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArchiveFTModelOut
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
        public global::G.ArchiveFTModelOutObject? Object { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveFTModelOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: model
        /// </param>
        /// <param name="archived">
        /// Default Value: true
        /// </param>
        public ArchiveFTModelOut(
            string id,
            global::G.ArchiveFTModelOutObject? @object,
            bool? archived)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Archived = archived;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveFTModelOut" /> class.
        /// </summary>
        public ArchiveFTModelOut()
        {
        }
    }
}