//HintName: G.Models.EnvVarSecretCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of the secret: env_var for regular environment variables, ai_provider for AI provider API keys<br/>
    /// Default Value: env_var
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EnvVarSecretCategory
    {
        /// <summary>
        /// env_var for regular environment variables, ai_provider for AI provider API keys
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai_provider")]
        AiProvider,
        /// <summary>
        /// env_var for regular environment variables, ai_provider for AI provider API keys
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="env_var")]
        EnvVar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sandbox_provider")]
        SandboxProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvVarSecretCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvVarSecretCategory value)
        {
            return value switch
            {
                EnvVarSecretCategory.AiProvider => "ai_provider",
                EnvVarSecretCategory.EnvVar => "env_var",
                EnvVarSecretCategory.SandboxProvider => "sandbox_provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvVarSecretCategory? ToEnum(string value)
        {
            return value switch
            {
                "ai_provider" => EnvVarSecretCategory.AiProvider,
                "env_var" => EnvVarSecretCategory.EnvVar,
                "sandbox_provider" => EnvVarSecretCategory.SandboxProvider,
                _ => null,
            };
        }
    }
}