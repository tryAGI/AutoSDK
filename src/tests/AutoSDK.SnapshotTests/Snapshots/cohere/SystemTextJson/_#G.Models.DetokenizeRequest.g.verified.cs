﻿//HintName: G.Models.DetokenizeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetokenizeRequest
    {
        /// <summary>
        /// An optional parameter to provide the model name. This will ensure that the detokenization is done by the tokenizer used by that model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The list of tokens to be detokenized.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<int>? Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// An optional parameter to provide the model name. This will ensure that the detokenization is done by the tokenizer used by that model.
        /// </param>
        /// <param name="tokens">
        /// The list of tokens to be detokenized.<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetokenizeRequest(
            string model,
            global::System.Collections.Generic.IList<int>? tokens)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeRequest" /> class.
        /// </summary>
        public DetokenizeRequest()
        {
        }
    }
}