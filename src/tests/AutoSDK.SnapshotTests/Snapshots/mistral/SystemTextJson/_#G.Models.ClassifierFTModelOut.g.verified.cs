﻿//HintName: G.Models.ClassifierFTModelOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifierFTModelOut
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FTModelCapabilitiesOut Capabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ClassifierTargetOut> ClassifierTargets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Job { get; set; }

        /// <summary>
        /// Default Value: 32768
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_context_length")]
        public int? MaxContextLength { get; set; }

        /// <summary>
        /// Default Value: classifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassifierFTModelOutModelTypeJsonConverter))]
        public global::G.ClassifierFTModelOutModelType? ModelType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassifierFTModelOutObjectJsonConverter))]
        public global::G.ClassifierFTModelOutObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Root { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierFTModelOut" /> class.
        /// </summary>
        /// <param name="aliases">
        /// Default Value: []
        /// </param>
        /// <param name="archived"></param>
        /// <param name="capabilities"></param>
        /// <param name="classifierTargets"></param>
        /// <param name="created"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="job"></param>
        /// <param name="maxContextLength">
        /// Default Value: 32768
        /// </param>
        /// <param name="modelType">
        /// Default Value: classifier
        /// </param>
        /// <param name="name"></param>
        /// <param name="object">
        /// Default Value: model
        /// </param>
        /// <param name="ownedBy"></param>
        /// <param name="root"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierFTModelOut(
            bool archived,
            global::G.FTModelCapabilitiesOut capabilities,
            global::System.Collections.Generic.IList<global::G.ClassifierTargetOut> classifierTargets,
            int created,
            string id,
            global::System.Guid job,
            string ownedBy,
            string root,
            global::System.Collections.Generic.IList<string>? aliases,
            string? description,
            int? maxContextLength,
            global::G.ClassifierFTModelOutModelType? modelType,
            string? name,
            global::G.ClassifierFTModelOutObject? @object)
        {
            this.Archived = archived;
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.ClassifierTargets = classifierTargets ?? throw new global::System.ArgumentNullException(nameof(classifierTargets));
            this.Created = created;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Job = job;
            this.OwnedBy = ownedBy ?? throw new global::System.ArgumentNullException(nameof(ownedBy));
            this.Root = root ?? throw new global::System.ArgumentNullException(nameof(root));
            this.Aliases = aliases;
            this.Description = description;
            this.MaxContextLength = maxContextLength;
            this.ModelType = modelType;
            this.Name = name;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierFTModelOut" /> class.
        /// </summary>
        public ClassifierFTModelOut()
        {
        }
    }
}