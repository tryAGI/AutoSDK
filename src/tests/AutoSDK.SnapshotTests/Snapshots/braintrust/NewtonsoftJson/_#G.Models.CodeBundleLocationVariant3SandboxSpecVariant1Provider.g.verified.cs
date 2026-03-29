//HintName: G.Models.CodeBundleLocationVariant3SandboxSpecVariant1Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeBundleLocationVariant3SandboxSpecVariant1Provider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="modal")]
        Modal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeBundleLocationVariant3SandboxSpecVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeBundleLocationVariant3SandboxSpecVariant1Provider value)
        {
            return value switch
            {
                CodeBundleLocationVariant3SandboxSpecVariant1Provider.Modal => "modal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeBundleLocationVariant3SandboxSpecVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "modal" => CodeBundleLocationVariant3SandboxSpecVariant1Provider.Modal,
                _ => null,
            };
        }
    }
}