//HintName: G.Models.UsageMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage metadata for a message, such as token counts.<br/>
    /// This is a standard representation of token usage that is consistent across models.<br/>
    /// Example:<br/>
    ///     .. code-block:: python<br/>
    ///         {<br/>
    ///             "input_tokens": 350,<br/>
    ///             "output_tokens": 240,<br/>
    ///             "total_tokens": 590,<br/>
    ///             "input_token_details": {<br/>
    ///                 "audio": 10,<br/>
    ///                 "cache_creation": 200,<br/>
    ///                 "cache_read": 100,<br/>
    ///             },<br/>
    ///             "output_token_details": {<br/>
    ///                 "audio": 10,<br/>
    ///                 "reasoning": 200,<br/>
    ///             }<br/>
    ///         }<br/>
    /// .. versionchanged:: 0.3.9<br/>
    ///     Added ``input_token_details`` and ``output_token_details``.
    /// </summary>
    public sealed partial class UsageMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// Breakdown of input token counts.<br/>
        /// Does *not* need to sum to full input token count. Does *not* need to have all keys.<br/>
        /// Example:<br/>
        ///     .. code-block:: python<br/>
        ///         {<br/>
        ///             "audio": 10,<br/>
        ///             "cache_creation": 200,<br/>
        ///             "cache_read": 100,<br/>
        ///         }<br/>
        /// .. versionadded:: 0.3.9
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_token_details")]
        public global::G.InputTokenDetails? InputTokenDetails { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("output_token_details")]
        public global::G.OutputTokenDetails? OutputTokenDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetadata" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="inputTokenDetails">
        /// Breakdown of input token counts.<br/>
        /// Does *not* need to sum to full input token count. Does *not* need to have all keys.<br/>
        /// Example:<br/>
        ///     .. code-block:: python<br/>
        ///         {<br/>
        ///             "audio": 10,<br/>
        ///             "cache_creation": 200,<br/>
        ///             "cache_read": 100,<br/>
        ///         }<br/>
        /// .. versionadded:: 0.3.9
        /// </param>
        /// <param name="outputTokenDetails">
        /// Breakdown of output token counts.<br/>
        /// Does *not* need to sum to full output token count. Does *not* need to have all keys.<br/>
        /// Example:<br/>
        ///     .. code-block:: python<br/>
        ///         {<br/>
        ///             "audio": 10,<br/>
        ///             "reasoning": 200,<br/>
        ///         }<br/>
        /// .. versionadded:: 0.3.9
        /// </param>
        public UsageMetadata(
            int inputTokens,
            int outputTokens,
            int totalTokens,
            global::G.InputTokenDetails? inputTokenDetails,
            global::G.OutputTokenDetails? outputTokenDetails)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
            this.InputTokenDetails = inputTokenDetails;
            this.OutputTokenDetails = outputTokenDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetadata" /> class.
        /// </summary>
        public UsageMetadata()
        {
        }
    }
}