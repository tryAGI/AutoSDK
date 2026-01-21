//HintName: G.Models.OpenAICompletionsInUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A unique identifier representing your end-user, which can help  monitor and detect abuse. Avoid sending us any identifying information. We recommend hashing user identifiers.
    /// </summary>
    public sealed partial class OpenAICompletionsInUser
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}