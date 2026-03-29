//HintName: G.Models.CreatePromptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// UUID or slug of the collection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionId { get; set; } = default!;

        /// <summary>
        /// Prompt template in string format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("string", Required = global::Newtonsoft.Json.Required.Always)]
        public string String { get; set; } = default!;

        /// <summary>
        /// Parameters for the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public object Parameters { get; set; } = default!;

        /// <summary>
        /// Functions for the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("functions")]
        public global::System.Collections.Generic.IList<object>? Functions { get; set; }

        /// <summary>
        /// Tools for the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<object>? Tools { get; set; }

        /// <summary>
        /// Tool Choice for the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public object? ToolChoice { get; set; }

        /// <summary>
        /// The model to use for the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The virtual key to use for the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("virtual_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string VirtualKey { get; set; } = default!;

        /// <summary>
        /// The description of the prompt version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Metadata for the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_metadata")]
        public object? TemplateMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="collectionId">
        /// UUID or slug of the collection
        /// </param>
        /// <param name="string">
        /// Prompt template in string format
        /// </param>
        /// <param name="parameters">
        /// Parameters for the prompt
        /// </param>
        /// <param name="virtualKey">
        /// The virtual key to use for the prompt
        /// </param>
        /// <param name="functions">
        /// Functions for the prompt
        /// </param>
        /// <param name="tools">
        /// Tools for the prompt
        /// </param>
        /// <param name="toolChoice">
        /// Tool Choice for the prompt
        /// </param>
        /// <param name="model">
        /// The model to use for the prompt
        /// </param>
        /// <param name="versionDescription">
        /// The description of the prompt version
        /// </param>
        /// <param name="templateMetadata">
        /// Metadata for the prompt
        /// </param>
        public CreatePromptRequest(
            string name,
            string collectionId,
            string @string,
            object parameters,
            string virtualKey,
            global::System.Collections.Generic.IList<object>? functions,
            global::System.Collections.Generic.IList<object>? tools,
            object? toolChoice,
            string? model,
            string? versionDescription,
            object? templateMetadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CollectionId = collectionId ?? throw new global::System.ArgumentNullException(nameof(collectionId));
            this.String = @string ?? throw new global::System.ArgumentNullException(nameof(@string));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Functions = functions;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Model = model;
            this.VirtualKey = virtualKey ?? throw new global::System.ArgumentNullException(nameof(virtualKey));
            this.VersionDescription = versionDescription;
            this.TemplateMetadata = templateMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptRequest" /> class.
        /// </summary>
        public CreatePromptRequest()
        {
        }
    }
}