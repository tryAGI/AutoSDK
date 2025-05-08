//HintName: G.Models.FunctionTool.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Defines a function in your own code the model can choose to call. Learn more about [function calling](https://platform.openai.com/docs/guides/function-calling).
    /// </summary>
    public sealed partial class FunctionTool
    {
        /// <summary>
        /// The type of the function tool. Always `function`.<br/>
        /// Default Value: function
        /// </summary>
        /// <default>global::G.FunctionToolType.Function</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionToolTypeJsonConverter))]
        public global::G.FunctionToolType Type { get; set; } = global::G.FunctionToolType.Function;

        /// <summary>
        /// The name of the function to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, object>))]
        public global::G.AnyOf<string, object>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<object, object> Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<bool?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<bool?, object> Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the function tool. Always `function`.<br/>
        /// Default Value: function
        /// </param>
        /// <param name="name">
        /// The name of the function to call.
        /// </param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="strict"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionTool(
            string name,
            global::G.AnyOf<object, object> parameters,
            global::G.AnyOf<bool?, object> strict,
            global::G.AnyOf<string, object>? description,
            global::G.FunctionToolType type = global::G.FunctionToolType.Function)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Parameters = parameters;
            this.Strict = strict;
            this.Type = type;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionTool" /> class.
        /// </summary>
        public FunctionTool()
        {
        }
    }
}