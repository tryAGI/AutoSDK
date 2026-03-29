//HintName: G.Models.EmailAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailAlert
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAlert" /> class.
        /// </summary>
        /// <param name="address"></param>
        public EmailAlert(
            string? address)
        {
            this.Address = address;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAlert" /> class.
        /// </summary>
        public EmailAlert()
        {
        }
    }
}