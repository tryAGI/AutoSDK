//HintName: G.Models.AgentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for an Agent.
    /// </summary>
    public sealed partial class AgentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("directoryId")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AgentResponseType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environments")]
        public global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdBy")]
        public global::G.UserResponse? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUsedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastUsedAt { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ToolFunction>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template")]
        public global::System.Collections.Generic.IList<global::G.ChatMessage>? Template { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentResponse" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="versionId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="directoryId"></param>
        /// <param name="model"></param>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="tags"></param>
        /// <param name="type"></param>
        /// <param name="environments"></param>
        /// <param name="createdBy"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="attributes"></param>
        /// <param name="tools"></param>
        /// <param name="template"></param>
        /// <param name="temperature"></param>
        /// <param name="maxTokens"></param>
        public AgentResponse(
            string path,
            string id,
            string name,
            string versionId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime lastUsedAt,
            string? directoryId,
            string? model,
            string? description,
            string? readme,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.AgentResponseType? type,
            global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? environments,
            global::G.UserResponse? createdBy,
            string? versionName,
            string? versionDescription,
            object? attributes,
            global::System.Collections.Generic.IList<global::G.ToolFunction>? tools,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? template,
            double? temperature,
            int? maxTokens)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DirectoryId = directoryId;
            this.Model = model;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Readme = readme;
            this.Tags = tags;
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.Type = type;
            this.Environments = environments;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreatedBy = createdBy;
            this.LastUsedAt = lastUsedAt;
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
            this.Attributes = attributes;
            this.Tools = tools;
            this.Template = template;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponse" /> class.
        /// </summary>
        public AgentResponse()
        {
        }
    }
}