//HintName: G.Models.AgentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template")]
        public global::System.Collections.Generic.IList<global::G.ChatMessage>? Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ToolFunction>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("linkedTools")]
        public global::System.Collections.Generic.IList<string>? LinkedTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxTokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequest" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="template"></param>
        /// <param name="tools"></param>
        /// <param name="linkedTools"></param>
        /// <param name="attributes"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="readme"></param>
        /// <param name="temperature"></param>
        /// <param name="maxTokens"></param>
        public AgentRequest(
            string? path,
            string? id,
            string? model,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? template,
            global::System.Collections.Generic.IList<global::G.ToolFunction>? tools,
            global::System.Collections.Generic.IList<string>? linkedTools,
            object? attributes,
            string? versionName,
            string? versionDescription,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            string? readme,
            double? temperature,
            int? maxTokens)
        {
            this.Path = path;
            this.Id = id;
            this.Model = model;
            this.Template = template;
            this.Tools = tools;
            this.LinkedTools = linkedTools;
            this.Attributes = attributes;
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
            this.Description = description;
            this.Tags = tags;
            this.Readme = readme;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequest" /> class.
        /// </summary>
        public AgentRequest()
        {
        }
    }
}