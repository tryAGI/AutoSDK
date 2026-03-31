//HintName: G.Models.LinearDataSourceCreateOrUpdateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating or updating a Linear data source.
    /// </summary>
    public sealed partial class LinearDataSourceCreateOrUpdateParams
    {
        /// <summary>
        /// The type of data source to create<br/>
        /// Default Value: linear
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The name of the data source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The metadata of the data source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The authentication parameters of the data source. Linear only supports OAuth2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_params")]
        public global::G.AuthParamsVariant12? AuthParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearDataSourceCreateOrUpdateParams" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the data source
        /// </param>
        /// <param name="type">
        /// The type of data source to create<br/>
        /// Default Value: linear
        /// </param>
        /// <param name="metadata">
        /// The metadata of the data source
        /// </param>
        /// <param name="authParams">
        /// The authentication parameters of the data source. Linear only supports OAuth2.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LinearDataSourceCreateOrUpdateParams(
            string name,
            string? type,
            object? metadata,
            global::G.AuthParamsVariant12? authParams)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata;
            this.AuthParams = authParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearDataSourceCreateOrUpdateParams" /> class.
        /// </summary>
        public LinearDataSourceCreateOrUpdateParams()
        {
        }
    }
}