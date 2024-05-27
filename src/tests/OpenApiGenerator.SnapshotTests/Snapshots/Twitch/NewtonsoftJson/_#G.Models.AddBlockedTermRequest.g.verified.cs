//HintName: G.Models.AddBlockedTermRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddBlockedTermRequest
    {
        /// <summary>
        /// The word or phrase to block from being used in the broadcaster’s chat room. The term must contain a minimum of 2 characters and may contain up to a maximum of 500 characters.  
        ///   
        /// Terms may include a wildcard character (\*). The wildcard character must appear at the beginning or end of a word or set of characters. For example, \*foo or foo\*.  
        ///   
        /// If the blocked term already exists, the response contains the existing blocked term.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}