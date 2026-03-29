//HintName: G.Models.UpdateTeamAPIKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTeamAPIKey
    {
        /// <summary>
        /// New name for the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamAPIKey" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the API key
        /// </param>
        public UpdateTeamAPIKey(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamAPIKey" /> class.
        /// </summary>
        public UpdateTeamAPIKey()
        {
        }
    }
}