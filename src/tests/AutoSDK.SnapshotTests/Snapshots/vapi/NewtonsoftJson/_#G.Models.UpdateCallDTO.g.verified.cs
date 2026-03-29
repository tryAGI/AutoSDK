//HintName: G.Models.UpdateCallDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCallDTO
    {
        /// <summary>
        /// This is the name of the call. This is just for your own reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCallDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the call. This is just for your own reference.
        /// </param>
        public UpdateCallDTO(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCallDTO" /> class.
        /// </summary>
        public UpdateCallDTO()
        {
        }
    }
}