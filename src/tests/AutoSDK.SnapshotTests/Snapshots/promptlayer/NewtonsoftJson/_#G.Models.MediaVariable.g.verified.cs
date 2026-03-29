//HintName: G.Models.MediaVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MediaVariable
    {
        /// <summary>
        /// Default Value: media_variable
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MediaVariableType? Type { get; set; }

        /// <summary>
        /// Name of the media variable
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaVariable" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the media variable
        /// </param>
        /// <param name="type">
        /// Default Value: media_variable
        /// </param>
        public MediaVariable(
            string name,
            global::G.MediaVariableType? type)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaVariable" /> class.
        /// </summary>
        public MediaVariable()
        {
        }
    }
}