//HintName: G.Models.FailResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FailResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tpe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FailMessage> Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Extras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FailResponse" /> class.
        /// </summary>
        /// <param name="tpe"></param>
        /// <param name="errors"></param>
        /// <param name="extras"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FailResponse(
            string tpe,
            global::System.Collections.Generic.IList<global::G.FailMessage> errors,
            object extras)
        {
            this.Tpe = tpe ?? throw new global::System.ArgumentNullException(nameof(tpe));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.Extras = extras ?? throw new global::System.ArgumentNullException(nameof(extras));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailResponse" /> class.
        /// </summary>
        public FailResponse()
        {
        }
    }
}