//HintName: G.Models.InputTokenDetails.g.cs

#nullable enable

namespace G
{
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
    public sealed partial class InputTokenDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public int? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_creation")]
        public int? CacheCreation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_read")]
        public int? CacheRead { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTokenDetails" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="cacheCreation"></param>
        /// <param name="cacheRead"></param>
        public InputTokenDetails(
            int? audio,
            int? cacheCreation,
            int? cacheRead)
        {
            this.Audio = audio;
            this.CacheCreation = cacheCreation;
            this.CacheRead = cacheRead;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTokenDetails" /> class.
        /// </summary>
        public InputTokenDetails()
        {
        }
    }
}