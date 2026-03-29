//HintName: G.Models.UserUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserUpdate
    {
        /// <summary>
        /// The id of the user to update.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The new name of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdate" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the user to update.
        /// </param>
        /// <param name="name">
        /// The new name of the user.
        /// </param>
        public UserUpdate(
            string id,
            string? name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdate" /> class.
        /// </summary>
        public UserUpdate()
        {
        }
    }
}