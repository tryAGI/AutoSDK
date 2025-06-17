﻿//HintName: G.Models.ToolV2Function.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The function to be executed.
    /// </summary>
    public sealed partial class ToolV2Function
    {
        /// <summary>
        /// The description of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The parameters of the function as a JSON schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolV2Function" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the function.
        /// </param>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="parameters">
        /// The parameters of the function as a JSON schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolV2Function(
            string name,
            object parameters,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolV2Function" /> class.
        /// </summary>
        public ToolV2Function()
        {
        }
    }
}