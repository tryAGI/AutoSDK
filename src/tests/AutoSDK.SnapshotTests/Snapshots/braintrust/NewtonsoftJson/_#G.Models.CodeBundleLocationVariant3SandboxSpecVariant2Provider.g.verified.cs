//HintName: G.Models.CodeBundleLocationVariant3SandboxSpecVariant2Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeBundleLocationVariant3SandboxSpecVariant2Provider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lambda")]
        Lambda,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeBundleLocationVariant3SandboxSpecVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeBundleLocationVariant3SandboxSpecVariant2Provider value)
        {
            return value switch
            {
                CodeBundleLocationVariant3SandboxSpecVariant2Provider.Lambda => "lambda",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeBundleLocationVariant3SandboxSpecVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "lambda" => CodeBundleLocationVariant3SandboxSpecVariant2Provider.Lambda,
                _ => null,
            };
        }
    }
}