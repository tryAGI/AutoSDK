//HintName: G.Models.ScimName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScimName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("formatted")]
        public string? Formatted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimName" /> class.
        /// </summary>
        /// <param name="formatted"></param>
        public ScimName(
            string? formatted)
        {
            this.Formatted = formatted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimName" /> class.
        /// </summary>
        public ScimName()
        {
        }
    }
}