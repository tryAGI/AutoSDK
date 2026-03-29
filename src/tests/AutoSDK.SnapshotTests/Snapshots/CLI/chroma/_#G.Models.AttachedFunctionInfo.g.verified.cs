//HintName: G.Models.AttachedFunctionInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttachedFunctionInfo
    {
        /// <summary>
        /// Name of the function (e.g., "record_counter", "statistics").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionName { get; set; }

        /// <summary>
        /// Unique identifier for the attached function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable name for the attached function instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedFunctionInfo" /> class.
        /// </summary>
        /// <param name="functionName">
        /// Name of the function (e.g., "record_counter", "statistics").
        /// </param>
        /// <param name="id">
        /// Unique identifier for the attached function.
        /// </param>
        /// <param name="name">
        /// Human-readable name for the attached function instance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachedFunctionInfo(
            string functionName,
            string id,
            string name)
        {
            this.FunctionName = functionName ?? throw new global::System.ArgumentNullException(nameof(functionName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedFunctionInfo" /> class.
        /// </summary>
        public AttachedFunctionInfo()
        {
        }
    }
}