//HintName: G.Models.ActionsVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsVariable
    {
        /// <summary>
        /// The name of the variable.<br/>
        /// Example: USERNAME
        /// </summary>
        /// <example>USERNAME</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The value of the variable.<br/>
        /// Example: octocat
        /// </summary>
        /// <example>octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// The date and time at which the variable was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.<br/>
        /// Example: 2019-01-24T22:45:36.000Z
        /// </summary>
        /// <example>2019-01-24T22:45:36.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time at which the variable was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.<br/>
        /// Example: 2019-01-24T22:45:36.000Z
        /// </summary>
        /// <example>2019-01-24T22:45:36.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsVariable" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the variable.<br/>
        /// Example: USERNAME
        /// </param>
        /// <param name="value">
        /// The value of the variable.<br/>
        /// Example: octocat
        /// </param>
        /// <param name="createdAt">
        /// The date and time at which the variable was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.<br/>
        /// Example: 2019-01-24T22:45:36.000Z
        /// </param>
        /// <param name="updatedAt">
        /// The date and time at which the variable was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.<br/>
        /// Example: 2019-01-24T22:45:36.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsVariable(
            string name,
            string value,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsVariable" /> class.
        /// </summary>
        public ActionsVariable()
        {
        }
    }
}