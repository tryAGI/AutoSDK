﻿//HintName: G.Models.ErrorError1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorError1
    {
        /// <summary>
        /// Example: Wrong ip
        /// </summary>
        /// <example>Wrong ip</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Example: Please provide a valid IP address
        /// </summary>
        /// <example>Please provide a valid IP address</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError1" /> class.
        /// </summary>
        /// <param name="title">
        /// Example: Wrong ip
        /// </param>
        /// <param name="message">
        /// Example: Please provide a valid IP address
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorError1(
            string title,
            string message)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError1" /> class.
        /// </summary>
        public ErrorError1()
        {
        }
    }
}