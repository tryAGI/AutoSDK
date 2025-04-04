﻿//HintName: G.Models.ProcessModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A model that is currently loaded.
    /// </summary>
    public sealed partial class ProcessModel
    {
        /// <summary>
        /// The model name. <br/>
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama3:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.<br/>
        /// Example: llama3.2
        /// </summary>
        /// <example>llama3.2</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Size of the model on disk.<br/>
        /// Example: 7323310500L
        /// </summary>
        /// <example>7323310500L</example>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public long? Size { get; set; }

        /// <summary>
        /// The model's digest.<br/>
        /// Example: sha256:bc07c81de745696fdf5afca05e065818a8149fb0c77266fb584d9b2cba3711a
        /// </summary>
        /// <example>sha256:bc07c81de745696fdf5afca05e065818a8149fb0c77266fb584d9b2cba3711a</example>
        [global::Newtonsoft.Json.JsonProperty("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// Details about a model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.ModelDetails? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Size of the model on disk.<br/>
        /// Example: 7323310500L
        /// </summary>
        /// <example>7323310500L</example>
        [global::Newtonsoft.Json.JsonProperty("size_vram")]
        public long? SizeVram { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessModel" /> class.
        /// </summary>
        /// <param name="model">
        /// The model name. <br/>
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama3:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.<br/>
        /// Example: llama3.2
        /// </param>
        /// <param name="size">
        /// Size of the model on disk.<br/>
        /// Example: 7323310500L
        /// </param>
        /// <param name="digest">
        /// The model's digest.<br/>
        /// Example: sha256:bc07c81de745696fdf5afca05e065818a8149fb0c77266fb584d9b2cba3711a
        /// </param>
        /// <param name="details">
        /// Details about a model.
        /// </param>
        /// <param name="expiresAt"></param>
        /// <param name="sizeVram">
        /// Size of the model on disk.<br/>
        /// Example: 7323310500L
        /// </param>
        public ProcessModel(
            string? model,
            long? size,
            string? digest,
            global::G.ModelDetails? details,
            global::System.DateTime? expiresAt,
            long? sizeVram)
        {
            this.Model = model;
            this.Size = size;
            this.Digest = digest;
            this.Details = details;
            this.ExpiresAt = expiresAt;
            this.SizeVram = sizeVram;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessModel" /> class.
        /// </summary>
        public ProcessModel()
        {
        }
    }
}