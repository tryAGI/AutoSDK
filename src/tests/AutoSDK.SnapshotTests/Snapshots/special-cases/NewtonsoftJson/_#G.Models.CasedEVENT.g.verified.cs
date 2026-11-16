//HintName: G.Models.CasedEVENT.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CasedEVENT
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CasedEVENTPayload Payload { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("onlyHere")]
        public string? OnlyHere { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CasedEVENT" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="onlyHere"></param>
        public CasedEVENT(
            global::G.CasedEVENTPayload payload,
            string? onlyHere)
        {
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.OnlyHere = onlyHere;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CasedEVENT" /> class.
        /// </summary>
        public CasedEVENT()
        {
        }

    }
}