//HintName: G.Models.GraderStringCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A StringCheckGrader object that performs a string comparison between input and reference using a specified operation.
    /// </summary>
    public sealed partial class GraderStringCheck
    {
        /// <summary>
        /// The object type, which is always `string_check`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraderStringCheckTypeJsonConverter))]
        public global::G.GraderStringCheckType Type { get; set; }

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The input text. This may include template strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// The reference text. This may include template strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reference { get; set; }

        /// <summary>
        /// The string check operation to perform. One of `eq`, `ne`, `like`, or `ilike`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraderStringCheckOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GraderStringCheckOperation Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderStringCheck" /> class.
        /// </summary>
        /// <param name="type">
        /// The object type, which is always `string_check`.
        /// </param>
        /// <param name="name">
        /// The name of the grader.
        /// </param>
        /// <param name="input">
        /// The input text. This may include template strings.
        /// </param>
        /// <param name="reference">
        /// The reference text. This may include template strings.
        /// </param>
        /// <param name="operation">
        /// The string check operation to perform. One of `eq`, `ne`, `like`, or `ilike`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraderStringCheck(
            string name,
            string input,
            string reference,
            global::G.GraderStringCheckOperation operation,
            global::G.GraderStringCheckType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Reference = reference ?? throw new global::System.ArgumentNullException(nameof(reference));
            this.Operation = operation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderStringCheck" /> class.
        /// </summary>
        public GraderStringCheck()
        {
        }
    }
}