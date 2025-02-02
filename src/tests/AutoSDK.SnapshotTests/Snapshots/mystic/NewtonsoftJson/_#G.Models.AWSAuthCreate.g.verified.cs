﻿//HintName: G.Models.AWSAuthCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class AWSAuthCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role_arn", Required = global::Newtonsoft.Json.Required.Always)]
        public string RoleArn { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSAuthCreate" /> class.
        /// </summary>
        /// <param name="roleArn"></param>
        public AWSAuthCreate(
            string roleArn)
        {
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSAuthCreate" /> class.
        /// </summary>
        public AWSAuthCreate()
        {
        }
    }
}