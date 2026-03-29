//HintName: G.Models.LlmLayer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmLayer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ToolDefinition>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speculative_inference")]
        public bool? SpeculativeInference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_body")]
        public object? ExtraBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_query")]
        public global::System.Collections.Generic.Dictionary<string, string>? DefaultQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmLayer" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="baseUrl"></param>
        /// <param name="apiKey"></param>
        /// <param name="tools"></param>
        /// <param name="speculativeInference"></param>
        /// <param name="headers"></param>
        /// <param name="extraBody"></param>
        /// <param name="defaultQuery"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmLayer(
            string? model,
            string? baseUrl,
            string? apiKey,
            global::System.Collections.Generic.IList<global::G.ToolDefinition>? tools,
            bool? speculativeInference,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            object? extraBody,
            global::System.Collections.Generic.Dictionary<string, string>? defaultQuery)
        {
            this.Model = model;
            this.BaseUrl = baseUrl;
            this.ApiKey = apiKey;
            this.Tools = tools;
            this.SpeculativeInference = speculativeInference;
            this.Headers = headers;
            this.ExtraBody = extraBody;
            this.DefaultQuery = defaultQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmLayer" /> class.
        /// </summary>
        public LlmLayer()
        {
        }
    }
}