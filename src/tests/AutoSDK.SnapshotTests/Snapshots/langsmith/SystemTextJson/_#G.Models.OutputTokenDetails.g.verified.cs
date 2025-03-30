//HintName: G.Models.OutputTokenDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Breakdown of output token counts.<br/>
    /// Does *not* need to sum to full output token count. Does *not* need to have all keys.<br/>
    /// Example:<br/>
    ///     .. code-block:: python<br/>
    ///         {<br/>
    ///             "audio": 10,<br/>
    ///             "reasoning": 200,<br/>
    ///         }<br/>
    /// .. versionadded:: 0.3.9
    /// </summary>
    public sealed partial class OutputTokenDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public int? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public int? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTokenDetails" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="reasoning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputTokenDetails(
            int? audio,
            int? reasoning)
        {
            this.Audio = audio;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTokenDetails" /> class.
        /// </summary>
        public OutputTokenDetails()
        {
        }
    }
}