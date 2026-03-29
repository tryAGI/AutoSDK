//HintName: G.Models.ToolRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::G.ToolFunction? Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceCode")]
        public string? SourceCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setupValues")]
        public object? SetupValues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolType")]
        public string? ToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRequest" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="function"></param>
        /// <param name="sourceCode"></param>
        /// <param name="setupValues"></param>
        /// <param name="attributes"></param>
        /// <param name="toolType"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="readme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolRequest(
            string? path,
            string? id,
            global::G.ToolFunction? function,
            string? sourceCode,
            object? setupValues,
            object? attributes,
            string? toolType,
            string? versionName,
            string? versionDescription,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            string? readme)
        {
            this.Path = path;
            this.Id = id;
            this.Function = function;
            this.SourceCode = sourceCode;
            this.SetupValues = setupValues;
            this.Attributes = attributes;
            this.ToolType = toolType;
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
            this.Description = description;
            this.Tags = tags;
            this.Readme = readme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRequest" /> class.
        /// </summary>
        public ToolRequest()
        {
        }
    }
}