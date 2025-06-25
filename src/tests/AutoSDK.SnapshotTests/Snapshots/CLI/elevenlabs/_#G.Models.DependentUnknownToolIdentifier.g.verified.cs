﻿//HintName: G.Models.DependentUnknownToolIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A model that represents an tool dependent on a knowledge base/tools<br/>
    /// to which the user has no direct access.
    /// </summary>
    public sealed partial class DependentUnknownToolIdentifier
    {
        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependentUnknownToolIdentifierTypeJsonConverter))]
        public global::G.DependentUnknownToolIdentifierType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentUnknownToolIdentifier" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: unknown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependentUnknownToolIdentifier(
            global::G.DependentUnknownToolIdentifierType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentUnknownToolIdentifier" /> class.
        /// </summary>
        public DependentUnknownToolIdentifier()
        {
        }
    }
}