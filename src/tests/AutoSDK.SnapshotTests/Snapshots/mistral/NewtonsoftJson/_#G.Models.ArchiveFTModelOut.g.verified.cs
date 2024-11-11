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
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived")]
        public bool? Archived { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveFTModelOut" /> class.
        /// </summary>
        /// <param name="archived">
        /// Default Value: true
        /// </param>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: model
        /// </param>
        public ArchiveFTModelOut(
            string id,
            bool? archived,
            global::G.ArchiveFTModelOutObject? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Archived = archived;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveFTModelOut" /> class.
        /// </summary>
        public ArchiveFTModelOut()
        {
        }
    }
}