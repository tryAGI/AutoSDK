//HintName: G.Models.DeleteServiceToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteServiceToken
    {
        /// <summary>
        /// Unique identifier for the service token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteServiceToken" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the service token.
        /// </param>
        public DeleteServiceToken(
            global::System.Guid id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteServiceToken" /> class.
        /// </summary>
        public DeleteServiceToken()
        {
        }
    }
}