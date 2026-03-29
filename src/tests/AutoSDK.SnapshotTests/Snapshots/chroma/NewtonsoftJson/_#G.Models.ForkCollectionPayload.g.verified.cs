//HintName: G.Models.ForkCollectionPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ForkCollectionPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForkCollectionPayload" /> class.
        /// </summary>
        /// <param name="newName"></param>
        public ForkCollectionPayload(
            string newName)
        {
            this.NewName = newName ?? throw new global::System.ArgumentNullException(nameof(newName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForkCollectionPayload" /> class.
        /// </summary>
        public ForkCollectionPayload()
        {
        }
    }
}