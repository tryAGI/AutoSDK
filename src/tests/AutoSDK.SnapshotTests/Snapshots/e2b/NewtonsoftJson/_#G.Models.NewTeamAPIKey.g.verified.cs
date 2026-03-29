//HintName: G.Models.NewTeamAPIKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewTeamAPIKey
    {
        /// <summary>
        /// Name of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewTeamAPIKey" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the API key
        /// </param>
        public NewTeamAPIKey(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewTeamAPIKey" /> class.
        /// </summary>
        public NewTeamAPIKey()
        {
        }
    }
}