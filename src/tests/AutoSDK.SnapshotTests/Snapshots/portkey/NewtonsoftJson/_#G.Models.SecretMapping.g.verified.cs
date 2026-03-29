//HintName: G.Models.SecretMapping.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretMapping
    {
        /// <summary>
        /// The field on the entity to populate from the secret reference. Must be unique within the array.<br/>
        /// - **Integrations**: `key` or `configurations.&lt;field&gt;` (e.g. `configurations.aws_secret_access_key`)<br/>
        /// - **Virtual Keys**: `key` or `model_config.&lt;field&gt;` (e.g. `model_config.awsSecretAccessKey`)<br/>
        /// Example: key
        /// </summary>
        /// <example>key</example>
        [global::Newtonsoft.Json.JsonProperty("target_field", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetField { get; set; } = default!;

        /// <summary>
        /// UUID or slug of the secret reference. Must belong to the same organisation and be accessible by the workspace.<br/>
        /// Example: my-aws-secret
        /// </summary>
        /// <example>my-aws-secret</example>
        [global::Newtonsoft.Json.JsonProperty("secret_reference_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SecretReferenceId { get; set; } = default!;

        /// <summary>
        /// Override the secret_key defined on the secret reference. Use to pick a specific key from a multi-value secret.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_key")]
        public string? SecretKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretMapping" /> class.
        /// </summary>
        /// <param name="targetField">
        /// The field on the entity to populate from the secret reference. Must be unique within the array.<br/>
        /// - **Integrations**: `key` or `configurations.&lt;field&gt;` (e.g. `configurations.aws_secret_access_key`)<br/>
        /// - **Virtual Keys**: `key` or `model_config.&lt;field&gt;` (e.g. `model_config.awsSecretAccessKey`)<br/>
        /// Example: key
        /// </param>
        /// <param name="secretReferenceId">
        /// UUID or slug of the secret reference. Must belong to the same organisation and be accessible by the workspace.<br/>
        /// Example: my-aws-secret
        /// </param>
        /// <param name="secretKey">
        /// Override the secret_key defined on the secret reference. Use to pick a specific key from a multi-value secret.
        /// </param>
        public SecretMapping(
            string targetField,
            string secretReferenceId,
            string? secretKey)
        {
            this.TargetField = targetField ?? throw new global::System.ArgumentNullException(nameof(targetField));
            this.SecretReferenceId = secretReferenceId ?? throw new global::System.ArgumentNullException(nameof(secretReferenceId));
            this.SecretKey = secretKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretMapping" /> class.
        /// </summary>
        public SecretMapping()
        {
        }
    }
}